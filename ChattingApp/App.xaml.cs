﻿using ChattingApp.Core;
using Dna;
using Fasetto.Word.Relational;
using System.Threading.Tasks;
using System.Windows;
using static ChattingApp.DI;
using static Dna.FrameworkDI;

namespace ChattingApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Custom startup so we load our IoC immediately before anything else
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            // Let the base application do what it needs
            base.OnStartup(e);

            // Setup the main application
            await ApplicationSetupAsync();

            // Log it
            Logger.LogDebugSource("Application starting...");

            // Setup the application view model based on if we are logged in
            // If we are logged in... go to chat page... otherwise go to login page
            ViewModelApplication.GoToPage(await ClientDataStore.HasCredentialsAsync() ? ApplicationPage.Chat : ApplicationPage.Login);

            // Show the main window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures our application ready for use
        /// </summary>
        private async Task ApplicationSetupAsync()
        {
            // Setup the Dna Framework
            Framework.Construct<DefaultFrameworkConstruction>()
                .AddFileLogger()
                .AddClientDataStore()
                .AddFasettoWordViewModels()
                .AddFasettoWordClientServices()
                .Build();

            // Ensure the client data store
            await ClientDataStore.EnsureDataStoreAsync();

            // Load new settings
            await ViewModelSettings.LoadAsync();
        }
    }
}
