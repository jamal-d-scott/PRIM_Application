using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class UserData
    {
        private DisplayMode Display;

        #region Constructors
        /// <summary>
        /// Constructor which gets the selected display mode passed from the selection screen.
        /// </summary>
        /// <param name="display">The current application's display mode (from selection screen (work, social, etc)).</param>
        public UserData(DisplayMode display)
        {
            this.Display = display;
        }
        #endregion

        #region Objects#
        /// <summary>
        /// Struct object for rapid getting/setting & allocation
        /// </summary>
        public struct UserInformation
        {
            public string Description { get; set; }

            public string Password { get; set; }
        }
        #endregion

        #region Variables
        public string EncryptionKey { get; set; }
        public string InitilizationVector { get; set; }
        #endregion

        #region Collections
        /// <summary>
        /// Creates a list of object Userinformation to hold multiple user items.
        /// </summary>
        public List<UserInformation> UserInformationCollection = new List<UserInformation>();
        #endregion

        #region Methods

        #region Loading
        /// <summary>
        /// Loads encrypted text from a respected file (from the display setting passed)
        /// decrypts and parses the the information.
        /// </summary>
        /// <returns>True if parse successful, false if unsuccessful</returns>
        public bool LoadData()
        {
            UserInformationCollection = new List<UserInformation>();
            var path = Display.Resource;
            string cipherText = string.Empty;

            using (var fileStream = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fileStream, true))
                {
                    cipherText = sr.ReadToEnd();
                }
            }

            if (!string.IsNullOrEmpty(cipherText))
            {
                Security.AES AES_SecurityPackage = new Security.AES(EncryptionKey, InitilizationVector);
                string plainText = AES_SecurityPackage.Decrypt(Encoding.Default.GetBytes(cipherText));

                if (string.IsNullOrEmpty(plainText))
                {
                    return false;
                }

                UserInformation info = new UserInformation();
                string parsed = string.Empty;
                for (int i = 0; i < plainText.Length; i++)
                {
                    if (plainText[i] == ' ')
                    {
                        info.Description = parsed;
                        parsed = string.Empty;
                    }
                    else if (plainText[i] == '\r' || plainText[i] == '\n' || plainText[i].Equals(Environment.NewLine))
                    {
                        if (info.Description != null)
                        {
                            info.Password = parsed;
                            UserInformationCollection.Add(info);
                            info = new UserInformation();
                        }
                        parsed = string.Empty;
                    }
                    else if (i == plainText.Length - 1)
                    {
                        parsed += plainText[i];
                        info.Password = parsed;
                        UserInformationCollection.Add(info);
                    }
                    else
                    {
                        parsed += plainText[i];
                    }
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to load and store the encryption key and initialization vector in memory
        /// if a key and IV is not recovered, it will generate a new key.
        /// </summary>
        /// <returns>False, if no key was located. True if key if found</returns>
        public bool LoadOrCreateEncryptionKey()
        {
            var key = AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.Key;
            using (var fileStream = File.Open(key, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fileStream, true))
                {
                    EncryptionKey = sr.ReadToEnd();
                }
            }

            var initializationVector = AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.InitializationVector;
            using (var fileStream = File.Open(initializationVector, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fileStream, true))
                {
                    InitilizationVector = sr.ReadToEnd();
                }
            }

            if (string.IsNullOrEmpty(EncryptionKey) || string.IsNullOrEmpty(InitilizationVector))
            {
                Security.AES AES_SecurityPackage = new Security.AES();
                AES_SecurityPackage.GenerateNewKey();
                return false;
            }

            return true;
        }
        #endregion

        #region Saving
        /// <summary>
        /// Encrypts and writes the UserInformationCollection to the file.
        /// </summary>
        public void SaveData()
        {
            string plaintext = string.Empty;
            var path = Display.Resource;
            Security.AES AES_SecurityPackage = new Security.AES(EncryptionKey, InitilizationVector);
            foreach (UserInformation information in UserInformationCollection)
            {
                plaintext += information.Description + " " + information.Password + Environment.NewLine;
            }
            byte[] cipherText = AES_SecurityPackage.Encrypt(plaintext);
            File.WriteAllText(path, Encoding.Default.GetString(cipherText));
        }
        #endregion
    }
    #endregion
}
