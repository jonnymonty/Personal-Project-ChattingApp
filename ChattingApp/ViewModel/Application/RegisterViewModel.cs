﻿using Dna;
using ChattingApp.Core;
using System.Threading.Tasks;
using System.Windows.Input;
using static ChattingApp.DI;

namespace ChattingApp
{
    /// <summary>
    /// The View Model for a register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The username of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the registerr is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            // Create commands
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));

            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        #endregion

        /// <summary>
        /// Attempts to register a new user
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task RegisterAsync(object parameter)
        {
            await RunCommandAsync(() => this.RegisterIsRunning, async () => 
            {
                // Call the server and attempt to register with the provided credentials
                // TODO: Move all URLs and API rroutes to static class in core
                var result = await WebRequests.PostAsync<ApiResponse<RegisterResultApiModel>>("https://localhost:5000/api/register", 
                    new RegisterCredentialsApiModel
                {
                    Username = Username,
                    Email = Email,
                    Password = (parameter as IHavePassword).SecurePassword.Unsecure()
                });

                // If there was no response, bad data, or a response with an error message...
                if (await result.DisplayErrorIfFailedAsync("Register Failed"))
                    return;

                // OK successfully registered and logged in ... now get users data
                var loginResult = result.ServerResponse.Response;

                // Let the application view model handle what happens
                // with the successful login
                await ViewModelApplication.HandleSuccessfulLoginAsync(loginResult);
            });
        }

        /// <summary>
        /// Takes the user to the lgin page
        /// </summary>
        /// <returns></returns>
        public async Task LoginAsync()
        {
            //IoC.Get<ApplicationViewModel>().SideMenuVisible ^= true;

            //return;

            // Go to login page
            ViewModelApplication.GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }
    }
}
