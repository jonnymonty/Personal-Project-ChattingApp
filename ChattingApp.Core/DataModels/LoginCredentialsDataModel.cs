using System;
using System.Collections.Generic;
using System.Text;

namespace ChattingApp.Core
{
    public class LoginCredentialsDataModel
    {
        /// <summary>
        /// The unique Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The users username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The users First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The users Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The users Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The users login token
        /// </summary>
        public string Token { get; set; }
    }
}
