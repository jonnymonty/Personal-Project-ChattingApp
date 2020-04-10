﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fasetto.Word.Web.Server
{
    /// <summary>
    /// The user data and profile for our application
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        #region Public Properties

        /// <summary>
        /// The users first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The users last name
        /// </summary>
        public string LastName { get; set; }

        #endregion
    }
}
