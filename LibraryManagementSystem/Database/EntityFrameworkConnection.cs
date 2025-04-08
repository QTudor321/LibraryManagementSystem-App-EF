using LibraryManagementSystem.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace LibraryManagementSystem.Database
{//clasa care conecteaza clasa intermediara la baza de date efectiva
    internal class EntityFrameworkConnection
    {
        public static IServiceProvider EntityDatabaseConnection()
        {
            //Obiectul pentru conectarea la baza de date
            var services = new ServiceCollection();
            //Conectarea la baza de date prin functia de adaugare context baza de date si detalii de server
            services.AddDbContext<LibraryDatabaseContext>(options => options.UseSqlServer("Server=DESKTOP-ID23M5J;Database=LibraryDatabase;Integrated Security=true;TrustServerCertificate = True;"));
            //Inregistrarea ferestrelor care au nevoie de injectie de dependenta(utilitati cu operatiile din baza de date)
            services.AddSingleton<LoginWindow>();
            //Returnarea serviciului de conectare la baza de date
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
