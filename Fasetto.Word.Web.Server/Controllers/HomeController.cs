using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fasetto.Word.Web.Server
{
    /// <summary>
    /// Manages the standard web server pages
    /// </summary>
    public class HomeController : Controller
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
        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            mContext = context;
            mUserManager = userManager;
            mSignInManger = signInManager;
        }

        #endregion

        public IActionResult Index()
        {
            // Make sure we have the database
            mContext.Database.EnsureCreated();

            if (!mContext.Settings.Any())
            {
                string id = Guid.NewGuid().ToString("N");

                mContext.Settings.Add(new SettingsDataModel
                {
                    Id = id,
                    Name = "BackgroundColor",
                    Value = "Red"
                });

                var settingsLocally = mContext.Settings.Local.Count();
                var settingsDatabase = mContext.Settings.Count();

                var firstLocal = mContext.Settings.Local.FirstOrDefault();
                var firstDatabase = mContext.Settings.FirstOrDefault();

                mContext.SaveChanges();

                settingsLocally = mContext.Settings.Local.Count();
                settingsDatabase = mContext.Settings.Count();

                firstLocal = mContext.Settings.Local.FirstOrDefault();
                firstDatabase = mContext.Settings.FirstOrDefault();
            }
            

            return View();
        }

        /// <summary>
        /// Creates our single user for now
        /// </summary>
        /// <returns></returns>
        [Route("create")]
        public async Task<IActionResult> CreateUserAsync()
        {
            await Task.Delay(0);

            var result = await mUserManager.CreateAsync(new ApplicationUser
            {
                UserName = "jonny",
                Email = "jonny@gmail.com",
                FirstName = "Jonny",
                LastName = "Monty",
            }, "password");

            if (result.Succeeded)
                return Content("User was created", "text/html");

            return Content("User creation failed", "text/html");
        }

        /// <summary>
        /// Private area.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [Route("private")]
        public IActionResult Private()
        {
            return Content($"This is a private area. Welcome {HttpContext.User.Identity.Name}", "text/html");
        }

        /// <summary>
        /// Log the user out
        /// </summary>
        /// <returns></returns>
        [Route("logout")]
        public async Task<IActionResult> SignOutAsync()
        {
            await AuthenticationHttpContextExtensions.SignOutAsync(HttpContext, IdentityConstants.ApplicationScheme);
            return Content("done");
        }

        /// <summary>
        /// An auto login page for testing
        /// </summary>
        /// <param name="returnUrl">The url to return to if successful</param>
        /// <returns></returns>
        [Route("login")]
        public async Task<IActionResult> LoginAsync(string returnUrl)
        {
            // Sign out any previous sessions
            await AuthenticationHttpContextExtensions.SignOutAsync(HttpContext, IdentityConstants.ApplicationScheme);

            // Sign user in with the valid credentials
            var result = await mSignInManger.PasswordSignInAsync("jonny", "password", true, false);

            // If successful
            if (result.Succeeded)
            {
                // If no return url
                if (string.IsNullOrEmpty(returnUrl))
                    // Go to home
                    return RedirectToAction(nameof(Index));

                // Otherwise go to return url
                return Redirect(returnUrl);
            }

            return Content("Failed to login", "text/html");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
