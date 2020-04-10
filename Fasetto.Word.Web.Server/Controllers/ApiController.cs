using ChattingApp.Core;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Web.Server.Controllers
{
    public class AuthorizeTokenAttribute : AuthorizeAttribute
    {
        public AuthorizeTokenAttribute()
        {
            AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme;
        }
    }

    /// <summary>
    /// Manages the Web API calls
    /// </summary>
    public class ApiController : Controller
    {
        #region Protected Members

        /// <summary>
        /// The scoped Application context
        /// </summary>
        protected ApplicationDbContext mContext;

        /// <summary>
        /// The manager for handling user creation, deletion, searching, roles etc...
        /// </summary>
        protected UserManager<ApplicationUser> mUserManager;

        /// <summary>
        /// The manager for handling signing in and out for our users
        /// </summary>
        protected SignInManager<ApplicationUser> mSignInManger;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context">The Injected context</param>
        /// <param name="userManager">The Identity sign in manager</param>
        /// <param name="signInManager">The Identity user manager</param>
        public ApiController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            mContext = context;
            mUserManager = userManager;
            mSignInManger = signInManager;
        }

        #endregion

        /// <summary>
        /// Tries to register for a new account on the server
        /// </summary>
        /// <param name="registerCredentials">The registration details</param>
        /// <returns>Returns the result of the register request</returns>
        [Route("api/register")]
        public async Task<ApiResponse<RegisterResultApiModel>> RegisterAsync([FromBody]RegisterCredentialsApiModel registerCredentials)
        {
            // The message when we fail to login
            var invalidErrorMessage = "Please provide all required details to register for an account";

            // The error response for a failed login
            var errorResponse = new ApiResponse<RegisterResultApiModel>
            {
                // Set error message
                ErrorMessage = invalidErrorMessage
            };

            // If we have no credentials...
            if (registerCredentials == null)
            {
                // return error message to user
                return errorResponse;
            }

            // Make sure we have a username
            if (string.IsNullOrWhiteSpace(registerCredentials.Username))
            {
                // return error message to user
                return errorResponse;
            }

            // Create the desired user from the given details
            var user = new ApplicationUser
            {
                UserName = registerCredentials.Username,
                FirstName = registerCredentials.FirstName,
                LastName = registerCredentials.LastName,
                Email = registerCredentials.Email
            };

            // Try and create a user
            var result = await mUserManager.CreateAsync(user, registerCredentials.Password);

            // If the registration was successful...
            if (result.Succeeded)
            {
                // Get the user details
                var userIdentity = await mUserManager.FindByNameAsync(registerCredentials.Username);

                // Generate an email verification code
                var emailVerificationCode = mUserManager.GenerateEmailConfirmationTokenAsync(user);

                // TODO: Email the user the verification code

                // Return valid response containing all users details
                return new ApiResponse<RegisterResultApiModel>
                {
                    Response = new RegisterResultApiModel
                    {
                        FirstName = userIdentity.FirstName,
                        LastName = userIdentity.LastName,
                        Email = userIdentity.Email,
                        Username = userIdentity.UserName,
                        Token = userIdentity.GenerateJwtToken()
                    }
                };
            }
            // Else if it failed...
            else
            {
                // Return the failed response
                return new ApiResponse<RegisterResultApiModel> 
                { 
                    // Aggregate all errors into a single error string
                    ErrorMessage = result.Errors.ToList()
                    .Select(f => f.Description)
                    .Aggregate((a, b) => $"{a}{Environment.NewLine}{b}") 
                };
            }
        }

        /// <summary>
        /// Logs in a user using a token-based authentication
        /// </summary>
        /// <param name="loginCredentials">The login details</param>
        /// <returns>Returns the result of the login request</returns>
        [Route("api/login")]
        public async Task<ApiResponse<LoginResultApiModel>> LogInAsync([FromBody]LoginCredentialsApiModel loginCredentials)
        {
            // The message when we fail to login
            var invalidErrorMessage = "Invalid username or password";

            // The error response for a failed login
            var errorResponse = new ApiResponse<LoginResultApiModel>
                {
                    // Set error message
                    ErrorMessage = invalidErrorMessage
                };

            // Make sure we have a username
            if (loginCredentials?.UsernameOrEmail == null || string.IsNullOrWhiteSpace(loginCredentials.UsernameOrEmail))
            {
                // return error message to user
                return errorResponse;
            }

            // Validate if the user credentials are correct

            // Is it an email?
            var isEmail = loginCredentials.UsernameOrEmail.Contains("@");

            // Get the user details
            var user = isEmail ? await mUserManager.FindByEmailAsync(loginCredentials.UsernameOrEmail) : await mUserManager.FindByNameAsync(loginCredentials.UsernameOrEmail);

            // If we failed to find the user....
            if (user == null)
            {
                // return error message to user
                return errorResponse;
            }

            // If we got here we have a user...
            // Let's validate the password

            // Get if password is valid
            var isValidPassword = await mUserManager.CheckPasswordAsync(user, loginCredentials.Password);

            // If the password was wrong
            if (!isValidPassword)
            {
                // Return error message to user
                return errorResponse;
            }

            // If we got here we are vaild and the user passed the correct login details
            // Get username
            var username = user.UserName;

            //var username = "jonny";
            //var email = "jonny@gmail.com";

            // return the token
            return new ApiResponse<LoginResultApiModel>
            { 
                // Pass back the user details and token
                Response = new LoginResultApiModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Username = user.UserName,
                    Token = user.GenerateJwtToken()
                }
            };
        }

        [AuthorizeToken]
        [Route("api/private")]
        public IActionResult Private()
        {
            var user = HttpContext.User;

            return Ok(new { privateData = $"some secret for {user.Identity.Name}" });
        }
    }
}