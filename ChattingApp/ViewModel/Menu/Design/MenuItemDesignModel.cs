using ChattingApp.Core;

namespace ChattingApp
{
    /// <summary>
    /// The design-time data for a <see cref="MenuItemViewModel"/>
    /// </summary>
    public class MenuItemDesignModel : MenuItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MenuItemDesignModel Instance { get; } = new MenuItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuItemDesignModel()
        {
            Text = "Hello World";
            Icon = IconType.File;
        } 

        #endregion
    }
}