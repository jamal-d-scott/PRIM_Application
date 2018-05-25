using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class PRIM_Software : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Handles the Load event of the ManagementScreen control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ManagementScreen_Load(object sender, EventArgs e)
        {
            //TO DO:
            //Incorperate Key I/O here
        }

        #region Variables

        private DisplayMode Display;
        private UserData UserSessionData;
        private DialogBox notification;
        public bool InitialDisplayModeSelected { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PRIM_Software"/> class.
        /// Sets all first-session-time use/one time settings.
        /// </summary>
        public PRIM_Software()
        {
            InitializeComponent();
            SetDefaultText();
            btnReset.BackColor = Color.DimGray;
            btnReset.Enabled = false;
            cbHidePasswordDisplay.Checked = true;
            cbHideNewPasswords.Checked = true;
            PasswordManagement.DisableTab(InfoManagementTab);
            PasswordManagement.DisableTab(InfoAddTab);
            InitialDisplayModeSelected = false;
            cbRedirect.Checked = true;
        }

        #endregion

        #region Selection Tile Handlers

        /// <summary>
        /// Loads /creates encryption keys and file data based on what was selected
        /// on the selection screen
        /// </summary>
        /// <param name="sender">The selected metro tile.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SetDisplayMode(object sender, EventArgs e)
        {
            if (!InitialDisplayModeSelected)
            {
                PasswordManagement.EnableTab(InfoManagementTab);
                PasswordManagement.EnableTab(InfoAddTab);
            }

            if (notification != null)
            {
                notification.Close();
            }

            ClearApplicationData();
            cbWebsites.DataSource = null;
            var tile = (MetroFramework.Controls.MetroTile)sender;
            switch (tile.Name)
            {
                case "mtWork":
                    this.Text = Constants.InformationSelectionScreen.WorkManagement;
                    this.Style = MetroFramework.MetroColorStyle.Default;
                    Display = new DisplayMode(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.WorkInformation);
                    break;
                case "mtPersonal":
                    this.Text = Constants.InformationSelectionScreen.PersonalManagement;
                    this.Style = MetroFramework.MetroColorStyle.Yellow;
                    Display = new DisplayMode(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.PersonalInformation);
                    break;
                case "mtSocialMedia":
                    this.Text = Constants.InformationSelectionScreen.SocialMediaManagement;
                    this.Style = MetroFramework.MetroColorStyle.Purple;
                    Display = new DisplayMode(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.SocialMediaInformation);
                    break;
                case "mtSharedContent":
                    this.Text = Constants.InformationSelectionScreen.SharedContentManagement;
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    Display = new DisplayMode(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.SharedInformation);
                    break;
                case "mtOther":
                    this.Text = Constants.InformationSelectionScreen.OtherManagement;
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    Display = new DisplayMode(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.OtherInformation);
                    break;
                default:
                    break;
            }

            this.Refresh();
            UserSessionData = new UserData(Display);
            if (UserSessionData.LoadOrCreateEncryptionKey())
            {
                if (UserSessionData.LoadData())
                {
                    PasswordManagement.SelectTab(InfoManagementTab);
                    BindDescriptionMenu();
                }
                else
                {
                    PasswordManagement.SelectTab(InfoAddTab);
                    notification = new DialogBox(Constants.InformationSelectionScreen.NoData, this.Style, this.DesktopLocation);
                    notification.Show();
                }
            }
            else
            {
                PasswordManagement.SelectTab(InfoAddTab);
                notification = new DialogBox(Constants.InformationSelectionScreen.FirstTimeUseMessage, this.Style, this.DesktopLocation);
                notification.Show();
            }
        }

        #endregion

        #region Button Handlers

        /// <summary>
        /// Updates the user collection information in memory and writes the updated collection to it's respective file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (notification != null)
            {
                notification.Close();
            }

            if (!string.IsNullOrEmpty(cbWebsites.Text))
            {
                var descriptionName = cbWebsites.Text;
                UserData.UserInformation updatedInfo = UserSessionData.UserInformationCollection.Where(x => x.Description == cbWebsites.Text).FirstOrDefault();
                UserSessionData.UserInformationCollection.Remove(updatedInfo);
                updatedInfo.Password = tbPasswordDisplay.Text;
                UserSessionData.UserInformationCollection.Add(updatedInfo);
                UserSessionData.SaveData();
                BindDescriptionMenu();
                UserSessionData.UserInformationCollection.OrderBy(x => x.Description);
                notification = new DialogBox(descriptionName + " has been successfully updated!", MetroFramework.MetroColorStyle.Green, this.DesktopLocation, "Update successful");
                notification.Show();
            }
            else
            {
                notification = new DialogBox("You must select a website to update!", MetroFramework.MetroColorStyle.Red, this.DesktopLocation, "No Site Selected");
                notification.Show();
            }
        }

        /// <summary>
        /// Resets the app settings to default and redirects the user from the Add tab
        /// to the selection tab.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearApplicationData();
            PasswordManagement.SelectTab(InfoTypeSelectionTab);
        }

        /// <summary>
        /// Updates the user information collection in memory and writes to it's respective file
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbWebDescription.Text) && !string.IsNullOrEmpty(tbNewPassword.Text) && !string.IsNullOrEmpty(tbConfirmNewPassword.Text))
            {
                var descriptionName = tbWebDescription.Text;
                var siteList = UserSessionData.UserInformationCollection.Select(x => x.Description);
                if (!siteList.Contains(tbWebDescription.Text))
                {
                    if (tbNewPassword.Text.Equals(tbConfirmNewPassword.Text))
                    {
                        UserData.UserInformation newInfo = new UserData.UserInformation();
                        newInfo.Description = tbWebDescription.Text;
                        newInfo.Password = tbConfirmNewPassword.Text;
                        UserSessionData.UserInformationCollection.Add(newInfo);
                        UserSessionData.LoadOrCreateEncryptionKey();
                        UserSessionData.SaveData();
                        UserSessionData.LoadData();
                        BindDescriptionMenu();

                        if (cbRedirect.Checked)
                        {
                            PasswordManagement.SelectTab(InfoManagementTab);
                        }
                        else
                        {
                            ClearApplicationData();
                        }

                        notification = new DialogBox("Information for: " + descriptionName + " has been successfully added!", MetroFramework.MetroColorStyle.Green, this.DesktopLocation, "Information Saved");
                        notification.Show();
                    }
                    else
                    {
                        notification = new DialogBox("Your passwords must patch.", MetroFramework.MetroColorStyle.Red, this.DesktopLocation, "Error");
                        notification.Show();
                    }
                }
                else
                {
                    notification = new DialogBox(descriptionName + " already exists.", MetroFramework.MetroColorStyle.Red, this.DesktopLocation, "Error");
                    notification.Show();
                }
            }
            else
            {
                notification = new DialogBox("A Description, Password and Confirmation Password are needed.", MetroFramework.MetroColorStyle.Red, this.DesktopLocation, "Error");
                notification.Show();
            }
        }

        /// <summary>
        /// Resets the application and data to first time use. All passwords and keys are deleted.
        /// Files are recreated on selection screen.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.WorkInformation);
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.PersonalInformation);
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.SharedInformation);
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.SocialMediaInformation);
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.OtherInformation);
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.Key);
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + Constants.FilePaths.InitializationVector);
            ClearApplicationData();
            InitialDisplayModeSelected = false;
            PasswordManagement.DisableTab(InfoManagementTab);
            PasswordManagement.DisableTab(InfoAddTab);
            PasswordManagement.SelectTab(InfoTypeSelectionTab);
            notification = new DialogBox("All data has been Reset! A new key has been generated. Please do not modify it.", MetroFramework.MetroColorStyle.Silver, this.DesktopLocation, "Reset");
            notification.Show();
        }

        /// <summary>
        /// Displays the password of the selected combobox item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (notification != null)
            {
                notification.Close();
            }

            if (UserSessionData.UserInformationCollection.Any())
            {
                if (!string.IsNullOrEmpty(cbWebsites.Text))
                {
                    tbPasswordDisplay.Text = UserSessionData.UserInformationCollection.Where(x => x.Description == cbWebsites.Text).Select(x => x.Password).FirstOrDefault();
                    tbPasswordDisplay.Style = MetroFramework.MetroColorStyle.Green;
                    tbPasswordDisplay.UseStyleColors = true;
                    tbPasswordDisplay.Focus();
                }
                else
                {
                    notification = new DialogBox("There must be a website selected to display information for.", MetroFramework.MetroColorStyle.Red, this.DesktopLocation, "No Website Selected");
                    notification.Show();
                }
            }
            else if (!UserSessionData.UserInformationCollection.Any())
            {
                notification = new DialogBox("There are no saved websites and passwords to display.", MetroFramework.MetroColorStyle.Silver, this.DesktopLocation, "No Data");
                notification.Show();
            }
        }

        /// <summary>
        /// Defaults and clears all application UI settings
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearApplicationData();
        }

        /// <summary>
        /// Removes a selected combobox item from memory and overwrites the file with the new data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbWebsites.Text))
            {
                var descriptionName = cbWebsites.Text;
                UserSessionData.UserInformationCollection.Remove(UserSessionData.UserInformationCollection.Where(x => x.Description == cbWebsites.Text).FirstOrDefault());
                UserSessionData.SaveData();
                UserSessionData.LoadData();
                BindDescriptionMenu();
                notification = new DialogBox(descriptionName + " has been successfully removed!", MetroFramework.MetroColorStyle.Green, this.DesktopLocation, "Information Removed");
                notification.Show();
            }
            else
            {
                notification = new DialogBox("There must be a website selected to remove data information for.", MetroFramework.MetroColorStyle.Red, this.DesktopLocation, "No Website Selected");
                notification.Show();
            }

            if (!UserSessionData.UserInformationCollection.Any())
            {
                if (notification != null)
                {
                    notification.Close();
                }

                PasswordManagement.SelectTab(InfoAddTab);
                notification = new DialogBox("All websites have been removed. Add new ones if you would like!", this.Style, this.DesktopLocation);
                notification.Show();
            }
        }

        #endregion

        #region Textbox Handlers

        /// <summary>
        /// Prevents spaces from being entered as key presses.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        #endregion

        #region Checkbox Handlers

        /// <summary>
        /// Enables the reset button. This control is to prevent accidental resets without
        /// needing a confirmation dialog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbEnableReset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableReset.Checked)
            {
                btnReset.BackColor = Color.Red;
                btnReset.Enabled = true;
            }
            else if (cbEnableReset.Checked == false)
            {
                btnReset.BackColor = Color.DimGray;
                btnReset.Enabled = false;
            }
        }

        /// <summary>
        /// Changes whether or not the displayed password in the management tab is in plain text or password text (********).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbHidePasswordDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHidePasswordDisplay.Checked)
            {
                tbPasswordDisplay.UseSystemPasswordChar = true;
            }
            else if (cbHidePasswordDisplay.Checked == false)
            {
                tbPasswordDisplay.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Changes whether or not the password fields on the add tab in plain text or password text (********).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbHideNewPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHideNewPasswords.Checked)
            {
                tbNewPassword.UseSystemPasswordChar = true;
                tbConfirmNewPassword.UseSystemPasswordChar = true;
            }
            else if (cbHideNewPasswords.Checked == false)
            {
                tbNewPassword.UseSystemPasswordChar = false;
                tbConfirmNewPassword.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// When the combobox is changed on the management tab, we clear out the password display and reset it's style.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbWebsites_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPasswordDisplay.Style = MetroFramework.MetroColorStyle.Default;
            tbPasswordDisplay.UseStyleColors = true;
            tbPasswordDisplay.Clear();
        }

        #endregion

        #region Label Handlers

        /// <summary>
        /// When the "Created By" label is clicked, the computer's default browser is opened
        /// and redirected to Jamal D. Scott's personal GitHub Page.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblCreator_Click(object sender, EventArgs e)
        {
            ProcessStartInfo GitHub_Jamal_D_Scott = new ProcessStartInfo(Constants.ExternalLinks.DeveloperGitHub);
            Process.Start(GitHub_Jamal_D_Scott);
        }

        #endregion

        #region Tab Handlers

        /// <summary>
        /// Clears the information on the previous page when a tab is exited
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Tab_Entered(object sender, EventArgs e)
        {
            ClearApplicationData();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Sets the empty text box messages.
        /// </summary>
        private void SetDefaultText()
        {
            //Management Screen Defaults
            tbWebDescription.WaterMark = Constants.InformationManagementScreen.DescriptionDefaultText;
            tbPasswordDisplay.WaterMark = Constants.InformationManagementScreen.PasswordDefaultText;

            //Add Screen Defaults
            tbWebDescription.WaterMark = Constants.InformationAdditionScreen.AddNewDescriptionDefaultText;
            tbNewPassword.WaterMark = Constants.InformationAdditionScreen.NewPasswordDefaultText;
            tbConfirmNewPassword.WaterMark = Constants.InformationAdditionScreen.ConfirmNewPasswordDefaultText;
        }

        /// <summary>
        /// Clears the applications controls and resets the application settings to default
        /// </summary>
        public void ClearApplicationData()
        {
            cbHidePasswordDisplay.Checked = true;
            cbHideNewPasswords.Checked = true;
            cbEnableReset.Checked = false;
            tbPasswordDisplay.Clear();
            tbWebDescription.Clear();
            tbNewPassword.Clear();
            tbConfirmNewPassword.Clear();
            cbWebsites.SelectedIndex = -1;
            tbPasswordDisplay.Style = MetroFramework.MetroColorStyle.Default;
            tbPasswordDisplay.UseStyleColors = true;
        }

        /// <summary>
        /// BRefreshes the description menu with updated collection information
        /// and clears out the selected item.
        /// </summary>
        private void BindDescriptionMenu()
        {
            cbWebsites.DataSource = null;
            cbWebsites.DataSource = UserSessionData.UserInformationCollection;
            cbWebsites.DisplayMember = "Description";
            cbWebsites.ValueMember = "Password";
            if (UserSessionData.UserInformationCollection.Any())
            {
                UserSessionData.UserInformationCollection.OrderBy(x => x.Description);
            }
            cbWebsites.SelectedIndex = -1;
        }

        #endregion
    }
}
