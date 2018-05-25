using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class DisplayMode
    {
        #region Constructors
        /// <summary>
        /// The respective file path to read and write data from/to based on the selection screen.
        /// </summary>
        public string Resource;

        public DisplayMode(string resource)
        {
            this.Resource = resource;
        }
        #endregion

        #region Variables
        /// <summary>
        /// Gets or sets the display setting.
        /// </summary>
        /// <value>
        /// The display from the selection screen.
        /// </value>
        public string DisplaySetting { get; set; }
        #endregion
    }
}
