﻿using ChattingApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static ChattingApp.DI;

namespace ChattingApp
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

        /// <summary>
        /// The command to clear the users data from the viewmodel
        /// </summary>
        public ICommand ClearUserDataCommand { get; set; }

        /// <summary>
        /// Loads the settings data from the client data store
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Saves the current name to the server
        /// </summary>
        public ICommand SaveNameCommand { get; set; }

        /// <summary>
        /// Saves the current username to the server
        /// </summary>
        public ICommand SaveUsernameCommand { get; set; }

        /// <summary>
        /// Saves the current Email to the server
        /// </summary>
        public ICommand SaveEmailCommand { get; set; }

        #endregion

        #region Constructor

        public SettingsViewModel()
        {
            // Create commands
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
            LogoutCommand = new RelayCommand(Logout);
            ClearUserDataCommand = new RelayCommand(ClearUserData);
            LoadCommand = new RelayCommand(async () => await LoadAsync());
            SaveNameCommand = new RelayCommand(async () => await SaveNameAsync());
            SaveUsernameCommand = new RelayCommand(async () => await SaveUsernameAsync());
            SaveEmailCommand = new RelayCommand(async () => await SaveEmailAsync());

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
            ViewModelApplication.SettingsMenuVisible = true;
        }

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        public void Close()
        {
            // Close settings menu
            ViewModelApplication.SettingsMenuVisible = false;
        }

        /// <summary>
        /// Logout of the application
        /// </summary>
        public void Logout()
        {
            // TODO: Confirm if user wants to logout

            // TODO: Clear any user data/cache

            // Clean all application level viewmodels that contain any information about the current user
            ClearUserData();

            // Bring user to login page
            ViewModelApplication.GoToPage(ApplicationPage.Login);
        }

        /// <summary>
        /// Clears any data specific to the current user
        /// </summary>
        public void ClearUserData()
        {
            // Clear all viewmodels containing the users info
            this.Name = null;
            this.Username = null;
            this.Password = null;
            this.Email = null;
        }

        /// <summary>
        /// Sets the settings view model properties based on the data in the client data store
        /// </summary>
        public async Task LoadAsync()
        {
            // Get the stored credentials
            var storedCredentials = await ClientDataStore.GetLoginCredentialsAsync();

            Name = new TextEntryViewModel 
            {
                Label = "Name",
                OriginalText = $"{storedCredentials?.FirstName} {storedCredentials?.LastName}",
                CommitAction = SaveNameAsync
            
            };

            Username = new TextEntryViewModel 
            {
                Label = "Username", 
                OriginalText = storedCredentials?.Username,
                CommitAction = SaveUsernameAsync
            };

            Password = new PasswordEntryViewModel 
            { 
                Label = "Password", 
                FakePassword = "********",
                CommitAction = SavePasswordAsync

            };

            Email = new TextEntryViewModel 
            { 
                Label = "Email", 
                OriginalText = storedCredentials?.Email,
                CommitAction = SaveEmailAsync
            };
        }

        /// <summary>
        /// Saves the new name to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveNameAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return fail
            return false;
        }

        /// <summary>
        /// Saves the new username to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveUsernameAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return success
            return true;
        }

        /// <summary>
        /// Saves the new email to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveEmailAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return fail
            return false;
        }

        /// <summary>
        /// Saves the new password to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SavePasswordAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return fail
            return false;
        }
    }
}