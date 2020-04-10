using ChattingApp.Core;
using Dna;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static ChattingApp.DI;

namespace ChattingApp
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

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

        public LoginViewModel()
        {
            // Create commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));

            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync());
        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => this.LoginIsRunning, async () => {

                // Call the server and attempt to login with credentials
                // TODO: Move all URLs and API rroutes to static class in core
                var result = await WebRequests.PostAsync<ApiResponse<LoginResultApiModel>>("https://localhost:5000/api/login", new LoginCredentialsApiModel
                {
                    UsernameOrEmail = Email,
                    Password = (parameter as IHavePassword).SecurePassword.Unsecure()
                });

                // If there was no response, bad data, or a response with an error message...
                if (await result.DisplayErrorIfFailedAsync("Login Failed"))
                    return;

                // OK successfully logged in ... now get users data
                var loginResult = result.ServerResponse.Response;

                // Let the application view model handle what happens
                // with the successful login
                await ViewModelApplication.HandleSuccessfulLoginAsync(loginResult);
            });
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            //IoC.Get<ApplicationViewModel>().SideMenuVisible ^= true;

            //return;

            // Go to register page
            ViewModelApplication.GoToPage(ApplicationPage.Register);

            await Task.Delay(1);
        }
    }
}
