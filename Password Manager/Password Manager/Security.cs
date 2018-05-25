using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    class Security
    {
        public class AES
        {

            #region Variables

            public string EncryptionKey { get; set; }

            public string InitilizationVector { get; set; }
            #endregion

            #region Constructors
            public AES() { }

            public AES(string encryptionKey, string initilizationVector)
            {
                EncryptionKey = encryptionKey;
                InitilizationVector = initilizationVector;
            }
            #endregion

            #region Encryption
            /// <summary>
            /// Encrypts the file.
            /// </summary>
            public byte[] Encrypt(string plainText)
            {
                byte[] encrypted;
                using (Aes AES = Aes.Create())
                {
                    ICryptoTransform encryptor = AES.CreateEncryptor(Encoding.Default.GetBytes(EncryptionKey), Encoding.Default.GetBytes(InitilizationVector));
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt, Encoding.Default))
                            {
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }
                return encrypted;
            }
            #endregion

            #region Decryption
            /// <summary>
            /// Decrypts the file.
            /// </summary>
            public string Decrypt(byte[] encryptedText)
            {
                string decrypted;
                using (Aes AES = Aes.Create())
                {
                    ICryptoTransform decryptor = AES.CreateDecryptor(Encoding.Default.GetBytes(EncryptionKey), Encoding.Default.GetBytes(InitilizationVector));
                    using (MemoryStream msDecrypt = new MemoryStream(encryptedText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                decrypted = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                return decrypted;
            }
            #endregion

            #region Key Generation
            /// <summary>
            /// Generates and writes the new key and IV.
            /// </summary>
            public void GenerateNewKey()
            {
                using (Aes AES = Aes.Create())
                {
                    EncryptionKey = Encoding.Default.GetString(AES.Key);
                    InitilizationVector = Encoding.Default.GetString(AES.IV);
                }

                var keyPath = AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.Key;
                var ivPath = AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.InitializationVector;

                File.WriteAllText(keyPath, EncryptionKey);
                File.WriteAllText(ivPath, InitilizationVector);
            }
            #endregion
        }

        #region Hashing Functions
        [Obsolete]
        public class SHA256 { }
        #endregion
    }
}
