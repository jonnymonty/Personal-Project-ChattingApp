using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChattingApp.Core
{
    /// <summary>
    /// The settings state as a view model
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The current users name
        /// </summary>
        public TextEntryViewModel Name { get; set; }

        /// <summary>
        /// The current users username
        /// </summary>
        public TextEntryViewModel Username { get; set; }

        /// <summary>
        /// The current users password
        /// </summary>
        public PasswordEntryViewModel Password { get; set; }

        /// <summary>
        /// The current users email
        /// </summary>
        public TextEntryViewModel Email { get; set; }

        /// <summary>
        /// The text for the logout button
        /// </summary>
        public string LogoutButtonText { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command to open the settings menu
        /// </summary>
        public ICommand OpenCommand { get; set; }

        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to logout of the application
        /// </summary>
        public ICommand LogoutCommand { get; set; }

        #endregion

        #region Constructor

        public SettingsViewModel()
        {
            // Create commands
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
            LogoutCommand = new RelayCommand(Logout);

            // TODO: Remove this with real information pulled from our database
            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Luke Melrose" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "luke" };
            Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "lukem@gmail.com" };

            //TODO: get from localization
            LogoutButtonText = "Logout";
        }

        #endregion

        /// <summary>
        /// Opens the settings menu
        /// </summary>
        public void Open()
        {
            // Open settings menu
            IoC.Application.SettingsMenuVisible = true;
        }

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        public void Close()
        {
            // Close settings menu
            IoC.Application.SettingsMenuVisible = false;
        }

        /// <summary>
        /// Logout of the application
        /// </summary>
        public void Logout()
        {
            // TODO: Confirm if user wants to logout

            // TODO: Clear any user data/cache

            // Clean all application level viewmodels that contain any information about the current user

            // Bring user to login page
            IoC.Application.GoToPage(ApplicationPage.Login);
        }
    }
}