using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    class Constants
    {
        #region File Paths
        public class FilePaths
        {
            public const string WorkInformation = @"/Data/Work.prim";
            public const string PersonalInformation = @"/Data/Personal.prim";
            public const string SharedInformation = @"/Data/Shared.prim";
            public const string SocialMediaInformation = @"/Data/SocialMedia.prim";
            public const string OtherInformation = @"/Data/Other.prim";
            public const string Key = @"/Authentication/Key.key";
            public const string InitializationVector = @"/Authentication/Vector.iv";
            public const string Log = @"/Log.txt";
        }
        #endregion

        #region Information Selection Screen
        public class InformationSelectionScreen
        {
            public const string FirstTimeUseMessage = "This appears to be your first time using this program. " +
                                                      "A special key will be generated for encrypting and decrypting your passwords. " +
                                                      "Do not modify this file as you will be unable read the contents of your password file. " +
                                                      "Please see the 'READ ME.txt' document in the installation folder for me details.";
            public const string InvalidKeyMessage = "A key is missing or corrupted.If your key is missing, you must reset all data." +
                                                   "Please refer to: 'READ ME.txt' and the Logs 'LOG.txt'!";
            public const string NoData = "You do not have any data saved for this feature. Lets get started by adding some!";
            public const string OtherManagement = "Other Management";
            public const string SharedContentManagement = "Shared Management";
            public const string SocialMediaManagement = "Media Management";
            public const string WorkManagement = "Work Management";
            public const string PersonalManagement = "Personal Management";
        }
        #endregion

        #region Information Management Screen
        public class InformationManagementScreen
        {
            public const string DescriptionDefaultText = "Description";
            public const string PasswordDefaultText = "Password Display";
        }
        #endregion

        #region Information Addition Screen
        public class InformationAdditionScreen
        {
            public const string AddNewDescriptionDefaultText = "Description";
            public const string NewPasswordDefaultText = "Password";
            public const string ConfirmNewPasswordDefaultText = "Confirm Password";
        }
        #endregion

        #region Extrenal Links
        public class ExternalLinks
        {
            public const string DeveloperGitHub = "https://github.com/jamal-d-scott";
        }
        #endregion
    }
}
