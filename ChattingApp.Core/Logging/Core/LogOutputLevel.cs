﻿using System;

namespace ChattingApp.Core
{
    /// <summary>
    /// The log level of detail to output in a message
    /// </summary>
    public enum LogOutputLevel
    {
        /// <summary>
        /// Logs everything
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Log all information except debug information
        /// </summary>
        Verbose = 2,

        /// <summary>
        /// Logs all informative message, ignoring any debug and verbose messages
        /// </summary>
        Informative = 3,

        /// <summary>
        /// Log only critical errors and warnings and success, but no general information
        /// </summary>
        Critical = 4,

        /// <summary>
        /// The logger will never output anything
        /// </summary>
        Nothing = 7,
    }
}
