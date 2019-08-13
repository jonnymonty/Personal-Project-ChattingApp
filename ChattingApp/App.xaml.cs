using ChattingApp.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
        protected override void OnStartup(StartupEventArgs e)
        {
            // Let the base application do what it needs
            base.OnStartup(e);

            // Setup the main application
            ApplicationSetup();

            // Log it
            IoC.Logger.Log("This is debug...", LogLevel.Debug);
            IoC.Logger.Log("This is error...", LogLevel.Error);
            IoC.Logger.Log("This is informative...", LogLevel.Informative);
            IoC.Logger.Log("This is success...", LogLevel.Success);
            IoC.Logger.Log("This is verbose...", LogLevel.Verbose);
            IoC.Logger.Log("This is warning...", LogLevel.Warning);

            // Show the main window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures our application ready for use
        /// </summary>
        private void ApplicationSetup()
        {
            // Setup IoC
            IoC.Setup();

            // Bind a UI Manager
            IoC.Kernel.Bind<IUIManager>().ToConstant(new UIManager());

            // Bind a logger
            IoC.Kernel.Bind<ILogFactory>().ToConstant(new BaseLogFactory());
        }
    }
}
