using ChattingApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dna;

namespace ChattingApp
{
    /// <summary>
    /// A shorthand access class to get DI services with nice clean short code
    /// </summary>
    public static class DI
    {
        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI => Framework.Service<IUIManager>();

        /// <summary>
        /// A shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel ViewModelApplication => Framework.Service<ApplicationViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static SettingsViewModel ViewModelSettings => Framework.Service<SettingsViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="ClientDataStore"/> service
        /// </summary>
        public static IClientDataStore ClientDataStore => Framework.Service<IClientDataStore>();
    }
}
