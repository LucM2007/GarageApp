using System.Configuration;
using System.Data;
using System.Runtime.Serialization.DataContracts;
using System.Windows;
using GarageApp.View;
using GarageApp.ViewModel;

namespace GarageApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new MainView()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();
        }
    }

}
