using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class DialogBox : MetroFramework.Forms.MetroForm
    {
        #region Initialization
        public DialogBox(string message, MetroFramework.MetroColorStyle style, Point location, string header = null)
        {
            InitializeComponent();
            //Centers the dialog box relative to the main form.
            location.X = location.X + 55;
            location.Y = location.Y + 200;
            this.DesktopLocation = location;
            this.Style = style;
            lblMessage.Text = message;
            lblMessage.Style = style;
            if(!string.IsNullOrEmpty(header))
            {
                this.Text = header;
            }
            else
            {
                this.Text = "Notification";
            }
            this.Refresh();
        }
        #endregion

        #region Button Handlers
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
