using ChattingApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp
{
    /// <summary>
    /// A view model for a menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The text to display for this menu item
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The icon for this menu item
        /// </summary>
        public IconType Icon { get; set; }

        /// <summary>
        /// They type of this menu item
        /// </summary>
        public MenuItemType Type { get; set; }
    }
}