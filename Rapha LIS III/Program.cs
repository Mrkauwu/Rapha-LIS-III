using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Rapha_LIS_III._Repositoties;
using Rapha_LIS_III.Models;
using Rapha_LIS_III.Presenters;
using Rapha_LIS_III.Views;

namespace Rapha_LIS_III
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Load configuration from appsettings.json using AppContext.BaseDirectory
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Use BaseDirectory instead
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Read the connection string
            string sqlConnectionString = config.GetConnectionString("DefaultConnection");

            // Initialize views and repositories
            IPatientView view = new MainForm();
            IPatientRepository repository = new PatientRepository(sqlConnectionString);
            new PatientPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}