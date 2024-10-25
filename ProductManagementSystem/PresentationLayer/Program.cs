using BusinessLayer.Services;
using DataLayer.DbConnection;
using DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<CategoryForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    //Forms
                    services.AddTransient<CategoryForm>();

                    //Repositories
                    services.AddScoped<ICategoryRepository, CategoryRepository>();

                    //Services
                    services.AddScoped<ICategoryService, CategoryService>();

                    //Connection
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                });
        }
    }
}