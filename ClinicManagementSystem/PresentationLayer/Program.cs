using BusinessLayer.Services.Doctors;
using BusinessLayer.Services.Patients;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories.Doctors;
using DataAccessLayer.Repositories.Patients;
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

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    //Forms
                    services.AddTransient<MainForm>();
                    services.AddTransient<DoctorForm>();
                    services.AddTransient<PatientForm>();

                    //Services from Business Layer
                    services.AddScoped<IDoctorService, DoctorService>();
                    services.AddScoped<IPatientService, PatientService>();

                    //Repositories from Data Layer
                    services.AddScoped<IDoctorRepository, DoctorRepository>();
                    services.AddScoped<IPatientRepository, PatientRepository>();

                    //Database connection service
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();

                });
        }

    }
}