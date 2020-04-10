using System;
using System.Runtime.CompilerServices;

namespace ChattingApp.Core
{
    /// <summary>
    /// Holds a bunch of loggers to log messages for the user
    /// </summary>
    public interface ILogFactory
    {
        #region Events

        /// <summary>
        /// Fires whenever a new log arrives
        /// </summary>
        event Action<(string Message, LogLevel Level)> NewLog;

        #endregion

        #region Properties

        /// <summary>
        /// The level of logging to output
        /// </summary>
        LogOutputLevel LogOutputLevel { get; set; }

        // If true, includes the origin of where the log message was logged from
        // such as the class name, line number and file name
        bool IncludeLogOriginDetails { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the specific logger to this factory
        /// </summary>
        /// <param name="logger">The logger to add</param>
        void AddLogger(ILogger logger);

        /// <summary>
        /// Removes the specified logger from the factory
        /// </summary>
        /// <param name="logger">The logger to remove</param>
        void RemoveLogger(ILogger logger);

        /// <summary>
        /// Logs the specific message to all loggers in this factory
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="level">The level of message being logged</param>
        /// <param name="origin">The method/function this message was logged in</param>
        /// <param name="filePath">The code filename that this message was logged from</param>
        /// <param name="lineNumber">The line of code in the filename this message was logged from</param>
        void Log(string message, LogLevel level = LogLevel.Informative, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);

        #endregion
    }
}