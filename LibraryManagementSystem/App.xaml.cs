using LibraryManagementSystem.Database;
using LibraryManagementSystem.Library;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;
        public App()
        {
            serviceProvider = EntityFrameworkConnection.EntityDatabaseConnection();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);//initializarea evenimentului
            var loginwindow = serviceProvider.GetRequiredService<LoginWindow>();
            loginwindow.Show();
        }
    }

}
