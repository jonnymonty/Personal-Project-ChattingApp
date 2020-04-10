﻿using Dna;
using System;

namespace ChattingApp.Core
{
    /// <summary>
    /// The IoC container for our application
    /// </summary>
    public static class CoreDI
    {

        /// <summary>
        /// A shortcut to access the <see cref="IFileManager"/>
        /// </summary>
        public static IFileManager FileManager => Framework.Service<IFileManager>();

        /// <summary>
        /// A shortcut to access the <see cref="ITaskManager"/>
        /// </summary>
        public static ITaskManager TaskManager => Framework.Service<ITaskManager>();
    }
}
