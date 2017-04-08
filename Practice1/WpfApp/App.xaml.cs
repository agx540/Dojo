using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using WpfApp.ViewModel;

namespace WpfApp
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            base.OnLoadCompleted(e);
          }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new WpfApp.MainWindow();
            var bootstrapper = new Bootstrapper();
            mainWindow.DataContext = new AlbumListViewModel(bootstrapper.Repository.Albums);
            mainWindow.Show();
        }
    }
}
