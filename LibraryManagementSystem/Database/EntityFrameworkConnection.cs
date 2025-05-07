using LibraryManagementSystem.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace LibraryManagementSystem.Database
{
    internal class EntityFrameworkConnection
    {
        public static IServiceProvider EntityDatabaseConnection()
        {
            var services = new ServiceCollection();
            services.AddDbContext<LibraryDatabaseContext>(options => options.UseSqlServer("Server=DESKTOP-ID23M5J;Database=LibraryDatabase;Integrated Security=true;TrustServerCertificate = True;"));
            services.AddSingleton<LoginWindow>();
            return services.BuildServiceProvider();
        }
        public static void TestDatabaseConnection(IServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetRequiredService<LibraryDatabaseContext>())
            {
                try
                {
                    var testResult = context.Users.FirstOrDefault();
                    if (testResult != null)
                        MessageBox.Show("Database Connection succesfull!");
                    else
                        MessageBox.Show("Database Connection succesfull, but data is invalid!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Connection failed: {ex.Message}");
                }
            }
        }
    }
}
