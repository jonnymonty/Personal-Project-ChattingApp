﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingApp.Core
{
    /// <summary>
    /// The design time data for a <see cref="SettingsViewModel"/>
    /// </summary>
    public class SettingsDesignModel : SettingsViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SettingsDesignModel Instance { get; } = new SettingsDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsDesignModel()
        {
            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Luke Melrose" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "luke" };
            Password = new TextEntryViewModel { Label = "Password", OriginalText = "*******" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "lukem@gmail.com" };
        }

        #endregion

    }
}