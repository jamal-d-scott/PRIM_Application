namespace Password_Manager
{
    partial class PRIM_Software
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRIM_Software));
            this.PasswordManagement = new MetroFramework.Controls.MetroTabControl();
            this.InfoTypeSelectionTab = new MetroFramework.Controls.MetroTabPage();
            this.mtSharedContent = new MetroFramework.Controls.MetroTile();
            this.mtSocialMedia = new MetroFramework.Controls.MetroTile();
            this.lblWebInfoType = new MetroFramework.Controls.MetroLabel();
            this.mtOther = new MetroFramework.Controls.MetroTile();
            this.mtPersonal = new MetroFramework.Controls.MetroTile();
            this.mtWork = new MetroFramework.Controls.MetroTile();
            this.InfoManagementTab = new MetroFramework.Controls.MetroTabPage();
            this.cbEnableReset = new MetroFramework.Controls.MetroCheckBox();
            this.lblReset = new MetroFramework.Controls.MetroLabel();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.cbHidePasswordDisplay = new MetroFramework.Controls.MetroCheckBox();
            this.lblManagementScreen = new MetroFramework.Controls.MetroLabel();
            this.tbPasswordDisplay = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnDisplay = new MetroFramework.Controls.MetroButton();
            this.cbWebsites = new MetroFramework.Controls.MetroComboBox();
            this.InfoAddTab = new MetroFramework.Controls.MetroTabPage();
            this.cbRedirect = new MetroFramework.Controls.MetroCheckBox();
            this.lblNoSpaces = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnAddNew = new MetroFramework.Controls.MetroButton();
            this.cbHideNewPasswords = new MetroFramework.Controls.MetroCheckBox();
            this.tbConfirmNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblAddNewInfo = new MetroFramework.Controls.MetroLabel();
            this.tbWebDescription = new MetroFramework.Controls.MetroTextBox();
            this.lblCreator = new MetroFramework.Controls.MetroLabel();
            this.PasswordManagement.SuspendLayout();
            this.InfoTypeSelectionTab.SuspendLayout();
            this.InfoManagementTab.SuspendLayout();
            this.InfoAddTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordManagement
            // 
            this.PasswordManagement.Controls.Add(this.InfoTypeSelectionTab);
            this.PasswordManagement.Controls.Add(this.InfoManagementTab);
            this.PasswordManagement.Controls.Add(this.InfoAddTab);
            this.PasswordManagement.Location = new System.Drawing.Point(11, 63);
            this.PasswordManagement.Name = "PasswordManagement";
            this.PasswordManagement.SelectedIndex = 2;
            this.PasswordManagement.Size = new System.Drawing.Size(510, 604);
            this.PasswordManagement.TabIndex = 41;
            this.PasswordManagement.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PasswordManagement.UseSelectable = true;
            // 
            // InfoTypeSelectionTab
            // 
            this.InfoTypeSelectionTab.Controls.Add(this.mtSharedContent);
            this.InfoTypeSelectionTab.Controls.Add(this.mtSocialMedia);
            this.InfoTypeSelectionTab.Controls.Add(this.lblWebInfoType);
            this.InfoTypeSelectionTab.Controls.Add(this.mtOther);
            this.InfoTypeSelectionTab.Controls.Add(this.mtPersonal);
            this.InfoTypeSelectionTab.Controls.Add(this.mtWork);
            this.InfoTypeSelectionTab.HorizontalScrollbarBarColor = true;
            this.InfoTypeSelectionTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InfoTypeSelectionTab.HorizontalScrollbarSize = 10;
            this.InfoTypeSelectionTab.Location = new System.Drawing.Point(4, 38);
            this.InfoTypeSelectionTab.Name = "InfoTypeSelectionTab";
            this.InfoTypeSelectionTab.Size = new System.Drawing.Size(502, 562);
            this.InfoTypeSelectionTab.Style = MetroFramework.MetroColorStyle.Lime;
            this.InfoTypeSelectionTab.TabIndex = 0;
            this.InfoTypeSelectionTab.Text = "Web Information Selection";
            this.InfoTypeSelectionTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InfoTypeSelectionTab.ToolTipText = "Select the typ/grouping of websites you would like to manage!";
            this.InfoTypeSelectionTab.VerticalScrollbarBarColor = true;
            this.InfoTypeSelectionTab.VerticalScrollbarHighlightOnWheel = false;
            this.InfoTypeSelectionTab.VerticalScrollbarSize = 10;
            this.InfoTypeSelectionTab.Enter += new System.EventHandler(this.Tab_Entered);
            // 
            // mtSharedContent
            // 
            this.mtSharedContent.ActiveControl = null;
            this.mtSharedContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtSharedContent.Location = new System.Drawing.Point(260, 254);
            this.mtSharedContent.Name = "mtSharedContent";
            this.mtSharedContent.Size = new System.Drawing.Size(159, 120);
            this.mtSharedContent.Style = MetroFramework.MetroColorStyle.Green;
            this.mtSharedContent.TabIndex = 12;
            this.mtSharedContent.Text = "Shared Content";
            this.mtSharedContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSharedContent.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSharedContent.UseSelectable = true;
            this.mtSharedContent.Click += new System.EventHandler(this.SetDisplayMode);
            // 
            // mtSocialMedia
            // 
            this.mtSocialMedia.ActiveControl = null;
            this.mtSocialMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtSocialMedia.Location = new System.Drawing.Point(80, 254);
            this.mtSocialMedia.Name = "mtSocialMedia";
            this.mtSocialMedia.Size = new System.Drawing.Size(159, 120);
            this.mtSocialMedia.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtSocialMedia.TabIndex = 11;
            this.mtSocialMedia.Text = "Social Media";
            this.mtSocialMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSocialMedia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSocialMedia.UseSelectable = true;
            this.mtSocialMedia.Click += new System.EventHandler(this.SetDisplayMode);
            // 
            // lblWebInfoType
            // 
            this.lblWebInfoType.AutoSize = true;
            this.lblWebInfoType.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWebInfoType.Location = new System.Drawing.Point(80, 69);
            this.lblWebInfoType.Name = "lblWebInfoType";
            this.lblWebInfoType.Size = new System.Drawing.Size(122, 25);
            this.lblWebInfoType.TabIndex = 10;
            this.lblWebInfoType.Text = "Web Info Type";
            this.lblWebInfoType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtOther
            // 
            this.mtOther.ActiveControl = null;
            this.mtOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtOther.Location = new System.Drawing.Point(80, 391);
            this.mtOther.Name = "mtOther";
            this.mtOther.Size = new System.Drawing.Size(339, 71);
            this.mtOther.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtOther.TabIndex = 9;
            this.mtOther.Text = "Additional/Other";
            this.mtOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOther.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOther.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtOther.UseSelectable = true;
            this.mtOther.Click += new System.EventHandler(this.SetDisplayMode);
            // 
            // mtPersonal
            // 
            this.mtPersonal.ActiveControl = null;
            this.mtPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtPersonal.Location = new System.Drawing.Point(260, 117);
            this.mtPersonal.Name = "mtPersonal";
            this.mtPersonal.Size = new System.Drawing.Size(159, 120);
            this.mtPersonal.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtPersonal.TabIndex = 8;
            this.mtPersonal.Text = "Personal";
            this.mtPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPersonal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPersonal.UseSelectable = true;
            this.mtPersonal.Click += new System.EventHandler(this.SetDisplayMode);
            // 
            // mtWork
            // 
            this.mtWork.ActiveControl = null;
            this.mtWork.BackColor = System.Drawing.Color.Black;
            this.mtWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtWork.Location = new System.Drawing.Point(80, 116);
            this.mtWork.Name = "mtWork";
            this.mtWork.Size = new System.Drawing.Size(159, 120);
            this.mtWork.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtWork.TabIndex = 7;
            this.mtWork.Text = "Work";
            this.mtWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtWork.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtWork.UseSelectable = true;
            this.mtWork.Click += new System.EventHandler(this.SetDisplayMode);
            // 
            // InfoManagementTab
            // 
            this.InfoManagementTab.Controls.Add(this.cbEnableReset);
            this.InfoManagementTab.Controls.Add(this.lblReset);
            this.InfoManagementTab.Controls.Add(this.btnReset);
            this.InfoManagementTab.Controls.Add(this.btnClear);
            this.InfoManagementTab.Controls.Add(this.btnUpdate);
            this.InfoManagementTab.Controls.Add(this.cbHidePasswordDisplay);
            this.InfoManagementTab.Controls.Add(this.lblManagementScreen);
            this.InfoManagementTab.Controls.Add(this.tbPasswordDisplay);
            this.InfoManagementTab.Controls.Add(this.btnDelete);
            this.InfoManagementTab.Controls.Add(this.btnDisplay);
            this.InfoManagementTab.Controls.Add(this.cbWebsites);
            this.InfoManagementTab.HorizontalScrollbarBarColor = true;
            this.InfoManagementTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InfoManagementTab.HorizontalScrollbarSize = 10;
            this.InfoManagementTab.Location = new System.Drawing.Point(4, 38);
            this.InfoManagementTab.Name = "InfoManagementTab";
            this.InfoManagementTab.Size = new System.Drawing.Size(502, 562);
            this.InfoManagementTab.Style = MetroFramework.MetroColorStyle.Lime;
            this.InfoManagementTab.TabIndex = 1;
            this.InfoManagementTab.Text = "Web Information";
            this.InfoManagementTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InfoManagementTab.VerticalScrollbarBarColor = true;
            this.InfoManagementTab.VerticalScrollbarHighlightOnWheel = false;
            this.InfoManagementTab.VerticalScrollbarSize = 10;
            this.InfoManagementTab.Enter += new System.EventHandler(this.Tab_Entered);
            // 
            // cbEnableReset
            // 
            this.cbEnableReset.AutoSize = true;
            this.cbEnableReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEnableReset.Location = new System.Drawing.Point(364, 428);
            this.cbEnableReset.Name = "cbEnableReset";
            this.cbEnableReset.Size = new System.Drawing.Size(89, 15);
            this.cbEnableReset.TabIndex = 51;
            this.cbEnableReset.Text = "Enable Reset";
            this.cbEnableReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbEnableReset.UseSelectable = true;
            this.cbEnableReset.CheckedChanged += new System.EventHandler(this.cbEnableReset_CheckedChanged);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblReset.Location = new System.Drawing.Point(48, 418);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(116, 25);
            this.lblReset.TabIndex = 50;
            this.lblReset.Text = "Reset All Data";
            this.lblReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReset.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnReset.Location = new System.Drawing.Point(48, 465);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(405, 52);
            this.btnReset.TabIndex = 49;
            this.btnReset.Text = "Reset";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseCustomBackColor = true;
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClear.Location = new System.Drawing.Point(262, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 52);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnUpdate.Location = new System.Drawing.Point(48, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 52);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbHidePasswordDisplay
            // 
            this.cbHidePasswordDisplay.AutoSize = true;
            this.cbHidePasswordDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHidePasswordDisplay.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbHidePasswordDisplay.Location = new System.Drawing.Point(48, 281);
            this.cbHidePasswordDisplay.Name = "cbHidePasswordDisplay";
            this.cbHidePasswordDisplay.Size = new System.Drawing.Size(154, 25);
            this.cbHidePasswordDisplay.TabIndex = 46;
            this.cbHidePasswordDisplay.Text = "Hide Passwords";
            this.cbHidePasswordDisplay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbHidePasswordDisplay.UseSelectable = true;
            this.cbHidePasswordDisplay.CheckedChanged += new System.EventHandler(this.cbHidePasswordDisplay_CheckedChanged);
            // 
            // lblManagementScreen
            // 
            this.lblManagementScreen.AutoSize = true;
            this.lblManagementScreen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblManagementScreen.Location = new System.Drawing.Point(48, 29);
            this.lblManagementScreen.Name = "lblManagementScreen";
            this.lblManagementScreen.Size = new System.Drawing.Size(250, 25);
            this.lblManagementScreen.TabIndex = 45;
            this.lblManagementScreen.Text = "Password Display/Management";
            this.lblManagementScreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbPasswordDisplay
            // 
            // 
            // 
            // 
            this.tbPasswordDisplay.CustomButton.Image = null;
            this.tbPasswordDisplay.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.tbPasswordDisplay.CustomButton.Name = "";
            this.tbPasswordDisplay.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbPasswordDisplay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPasswordDisplay.CustomButton.TabIndex = 1;
            this.tbPasswordDisplay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPasswordDisplay.CustomButton.UseSelectable = true;
            this.tbPasswordDisplay.CustomButton.Visible = false;
            this.tbPasswordDisplay.DisplayIcon = true;
            this.tbPasswordDisplay.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbPasswordDisplay.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbPasswordDisplay.Lines = new string[0];
            this.tbPasswordDisplay.Location = new System.Drawing.Point(48, 231);
            this.tbPasswordDisplay.MaxLength = 32767;
            this.tbPasswordDisplay.Name = "tbPasswordDisplay";
            this.tbPasswordDisplay.PasswordChar = '\0';
            this.tbPasswordDisplay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPasswordDisplay.SelectedText = "";
            this.tbPasswordDisplay.SelectionLength = 0;
            this.tbPasswordDisplay.SelectionStart = 0;
            this.tbPasswordDisplay.ShortcutsEnabled = true;
            this.tbPasswordDisplay.Size = new System.Drawing.Size(405, 32);
            this.tbPasswordDisplay.TabIndex = 44;
            this.tbPasswordDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPasswordDisplay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbPasswordDisplay.UseSelectable = true;
            this.tbPasswordDisplay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPasswordDisplay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDelete.Location = new System.Drawing.Point(262, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 52);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDisplay.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnDisplay.Location = new System.Drawing.Point(48, 144);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(191, 52);
            this.btnDisplay.TabIndex = 42;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDisplay.UseSelectable = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cbWebsites
            // 
            this.cbWebsites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbWebsites.DisplayFocus = true;
            this.cbWebsites.FormattingEnabled = true;
            this.cbWebsites.ItemHeight = 23;
            this.cbWebsites.Location = new System.Drawing.Point(48, 83);
            this.cbWebsites.Name = "cbWebsites";
            this.cbWebsites.Size = new System.Drawing.Size(405, 29);
            this.cbWebsites.TabIndex = 41;
            this.cbWebsites.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbWebsites.UseSelectable = true;
            this.cbWebsites.SelectedIndexChanged += new System.EventHandler(this.cbWebsites_SelectedIndexChanged);
            // 
            // InfoAddTab
            // 
            this.InfoAddTab.Controls.Add(this.cbRedirect);
            this.InfoAddTab.Controls.Add(this.lblNoSpaces);
            this.InfoAddTab.Controls.Add(this.btnCancel);
            this.InfoAddTab.Controls.Add(this.btnAddNew);
            this.InfoAddTab.Controls.Add(this.cbHideNewPasswords);
            this.InfoAddTab.Controls.Add(this.tbConfirmNewPassword);
            this.InfoAddTab.Controls.Add(this.tbNewPassword);
            this.InfoAddTab.Controls.Add(this.lblAddNewInfo);
            this.InfoAddTab.Controls.Add(this.tbWebDescription);
            this.InfoAddTab.HorizontalScrollbarBarColor = true;
            this.InfoAddTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InfoAddTab.HorizontalScrollbarSize = 10;
            this.InfoAddTab.Location = new System.Drawing.Point(4, 38);
            this.InfoAddTab.Name = "InfoAddTab";
            this.InfoAddTab.Size = new System.Drawing.Size(502, 562);
            this.InfoAddTab.TabIndex = 2;
            this.InfoAddTab.Text = "Add New Web Information";
            this.InfoAddTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InfoAddTab.VerticalScrollbarBarColor = true;
            this.InfoAddTab.VerticalScrollbarHighlightOnWheel = false;
            this.InfoAddTab.VerticalScrollbarSize = 10;
            this.InfoAddTab.Enter += new System.EventHandler(this.Tab_Entered);
            // 
            // cbRedirect
            // 
            this.cbRedirect.AutoSize = true;
            this.cbRedirect.Location = new System.Drawing.Point(277, 433);
            this.cbRedirect.Name = "cbRedirect";
            this.cbRedirect.Size = new System.Drawing.Size(176, 15);
            this.cbRedirect.TabIndex = 27;
            this.cbRedirect.Text = "Redirect to Infomation Page?";
            this.cbRedirect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbRedirect.UseSelectable = true;
            // 
            // lblNoSpaces
            // 
            this.lblNoSpaces.AutoSize = true;
            this.lblNoSpaces.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNoSpaces.Location = new System.Drawing.Point(48, 114);
            this.lblNoSpaces.Name = "lblNoSpaces";
            this.lblNoSpaces.Size = new System.Drawing.Size(137, 15);
            this.lblNoSpaces.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNoSpaces.TabIndex = 26;
            this.lblNoSpaces.Text = "Spaces are not permitted.";
            this.lblNoSpaces.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNoSpaces.UseStyleColors = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnCancel.Location = new System.Drawing.Point(262, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 52);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddNew.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAddNew.Location = new System.Drawing.Point(48, 355);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(191, 52);
            this.btnAddNew.TabIndex = 24;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddNew.UseSelectable = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cbHideNewPasswords
            // 
            this.cbHideNewPasswords.AutoSize = true;
            this.cbHideNewPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHideNewPasswords.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbHideNewPasswords.Location = new System.Drawing.Point(48, 308);
            this.cbHideNewPasswords.Name = "cbHideNewPasswords";
            this.cbHideNewPasswords.Size = new System.Drawing.Size(154, 25);
            this.cbHideNewPasswords.TabIndex = 23;
            this.cbHideNewPasswords.Text = "Hide Passwords";
            this.cbHideNewPasswords.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbHideNewPasswords.UseSelectable = true;
            this.cbHideNewPasswords.CheckedChanged += new System.EventHandler(this.cbHideNewPasswords_CheckedChanged);
            // 
            // tbConfirmNewPassword
            // 
            // 
            // 
            // 
            this.tbConfirmNewPassword.CustomButton.Image = null;
            this.tbConfirmNewPassword.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.tbConfirmNewPassword.CustomButton.Name = "";
            this.tbConfirmNewPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbConfirmNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbConfirmNewPassword.CustomButton.TabIndex = 1;
            this.tbConfirmNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbConfirmNewPassword.CustomButton.UseSelectable = true;
            this.tbConfirmNewPassword.CustomButton.Visible = false;
            this.tbConfirmNewPassword.DisplayIcon = true;
            this.tbConfirmNewPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbConfirmNewPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbConfirmNewPassword.IconRight = true;
            this.tbConfirmNewPassword.Lines = new string[0];
            this.tbConfirmNewPassword.Location = new System.Drawing.Point(48, 257);
            this.tbConfirmNewPassword.MaxLength = 32767;
            this.tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            this.tbConfirmNewPassword.PasswordChar = '\0';
            this.tbConfirmNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConfirmNewPassword.SelectedText = "";
            this.tbConfirmNewPassword.SelectionLength = 0;
            this.tbConfirmNewPassword.SelectionStart = 0;
            this.tbConfirmNewPassword.ShortcutsEnabled = true;
            this.tbConfirmNewPassword.Size = new System.Drawing.Size(405, 32);
            this.tbConfirmNewPassword.TabIndex = 22;
            this.tbConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmNewPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbConfirmNewPassword.UseSelectable = true;
            this.tbConfirmNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbConfirmNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbConfirmNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbNewPassword
            // 
            // 
            // 
            // 
            this.tbNewPassword.CustomButton.Image = null;
            this.tbNewPassword.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.tbNewPassword.CustomButton.Name = "";
            this.tbNewPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNewPassword.CustomButton.TabIndex = 1;
            this.tbNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNewPassword.CustomButton.UseSelectable = true;
            this.tbNewPassword.CustomButton.Visible = false;
            this.tbNewPassword.DisplayIcon = true;
            this.tbNewPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbNewPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbNewPassword.IconRight = true;
            this.tbNewPassword.Lines = new string[0];
            this.tbNewPassword.Location = new System.Drawing.Point(48, 195);
            this.tbNewPassword.MaxLength = 32767;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '\0';
            this.tbNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNewPassword.SelectedText = "";
            this.tbNewPassword.SelectionLength = 0;
            this.tbNewPassword.SelectionStart = 0;
            this.tbNewPassword.ShortcutsEnabled = true;
            this.tbNewPassword.Size = new System.Drawing.Size(405, 32);
            this.tbNewPassword.TabIndex = 21;
            this.tbNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNewPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbNewPassword.UseSelectable = true;
            this.tbNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // lblAddNewInfo
            // 
            this.lblAddNewInfo.AutoSize = true;
            this.lblAddNewInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAddNewInfo.Location = new System.Drawing.Point(48, 71);
            this.lblAddNewInfo.Name = "lblAddNewInfo";
            this.lblAddNewInfo.Size = new System.Drawing.Size(215, 25);
            this.lblAddNewInfo.TabIndex = 20;
            this.lblAddNewInfo.Text = "Add New Web Information";
            this.lblAddNewInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbWebDescription
            // 
            // 
            // 
            // 
            this.tbWebDescription.CustomButton.Image = null;
            this.tbWebDescription.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.tbWebDescription.CustomButton.Name = "";
            this.tbWebDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbWebDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbWebDescription.CustomButton.TabIndex = 1;
            this.tbWebDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbWebDescription.CustomButton.UseSelectable = true;
            this.tbWebDescription.CustomButton.Visible = false;
            this.tbWebDescription.DisplayIcon = true;
            this.tbWebDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbWebDescription.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbWebDescription.IconRight = true;
            this.tbWebDescription.Lines = new string[0];
            this.tbWebDescription.Location = new System.Drawing.Point(48, 136);
            this.tbWebDescription.MaxLength = 32767;
            this.tbWebDescription.Name = "tbWebDescription";
            this.tbWebDescription.PasswordChar = '\0';
            this.tbWebDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbWebDescription.SelectedText = "";
            this.tbWebDescription.SelectionLength = 0;
            this.tbWebDescription.SelectionStart = 0;
            this.tbWebDescription.ShortcutsEnabled = true;
            this.tbWebDescription.Size = new System.Drawing.Size(405, 32);
            this.tbWebDescription.TabIndex = 19;
            this.tbWebDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWebDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbWebDescription.UseSelectable = true;
            this.tbWebDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbWebDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbWebDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreator.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCreator.Location = new System.Drawing.Point(330, 31);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(182, 15);
            this.lblCreator.TabIndex = 42;
            this.lblCreator.Text = "Designed By: Jamal D\'eShaun Scott";
            this.lblCreator.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblCreator.Click += new System.EventHandler(this.lblCreator_Click);
            // 
            // PRIM_Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 650);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.PasswordManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PRIM_Software";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Password Management";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ManagementScreen_Load);
            this.PasswordManagement.ResumeLayout(false);
            this.InfoTypeSelectionTab.ResumeLayout(false);
            this.InfoTypeSelectionTab.PerformLayout();
            this.InfoManagementTab.ResumeLayout(false);
            this.InfoManagementTab.PerformLayout();
            this.InfoAddTab.ResumeLayout(false);
            this.InfoAddTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private MetroFramework.Controls.MetroTabControl PasswordManagement;
        private MetroFramework.Controls.MetroTabPage InfoTypeSelectionTab;
        private MetroFramework.Controls.MetroLabel lblWebInfoType;
        private MetroFramework.Controls.MetroTile mtOther;
        private MetroFramework.Controls.MetroTile mtWork;
        private MetroFramework.Controls.MetroTabPage InfoManagementTab;
        private MetroFramework.Controls.MetroLabel lblReset;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroCheckBox cbHidePasswordDisplay;
        private MetroFramework.Controls.MetroLabel lblManagementScreen;
        private MetroFramework.Controls.MetroTextBox tbPasswordDisplay;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnDisplay;
        private MetroFramework.Controls.MetroComboBox cbWebsites;
        private MetroFramework.Controls.MetroTile mtSocialMedia;
        private MetroFramework.Controls.MetroTile mtPersonal;
        private MetroFramework.Controls.MetroTile mtSharedContent;
        private MetroFramework.Controls.MetroTabPage InfoAddTab;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnAddNew;
        private MetroFramework.Controls.MetroCheckBox cbHideNewPasswords;
        private MetroFramework.Controls.MetroTextBox tbConfirmNewPassword;
        private MetroFramework.Controls.MetroTextBox tbNewPassword;
        private MetroFramework.Controls.MetroLabel lblAddNewInfo;
        private MetroFramework.Controls.MetroTextBox tbWebDescription;
        private MetroFramework.Controls.MetroCheckBox cbEnableReset;
        private MetroFramework.Controls.MetroLabel lblCreator;
        private MetroFramework.Controls.MetroLabel lblNoSpaces;
        private MetroFramework.Controls.MetroCheckBox cbRedirect;
    }
}

