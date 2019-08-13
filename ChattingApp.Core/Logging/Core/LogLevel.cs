﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChattingApp.Core
{
    public enum LogLevel
    {
        /// <summary>
        /// Developer-specific information
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Verbose information
        /// </summary>
        Verbose = 2,

        /// <summary>
        /// General information
        /// </summary>
        Informative = 3,

        /// <summary>
        /// A warning
        /// </summary>
        Warning = 4,

        /// <summary>
        /// An error
        /// </summary>
        Error = 5,

        /// <summary>
        /// A success
        /// </summary>
        Success = 6,
    }
}
