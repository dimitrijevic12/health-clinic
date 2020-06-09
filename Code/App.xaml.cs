using Controller;
using Model.SystemUsers;
using Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace health_clinicClassDiagram
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string DOCTOR_FILE = "../../Resources/Data/doctors.csv";
        private const string CSV_DELIMITER = ",";
        private const string DATETIME_FORMAT = "dd.MM.yyyy.";

        public IController<Doctor> doctorController { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            //var langCode = health_clinicClassDiagram.View.Properties.Settings.Default.languageCode;
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(langCode);
            var langCode = health_clinicClassDiagram.Properties.Settings.Default.languageCode;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(langCode);
            base.OnStartup(e);
        }

        public App()
        {
          /*  var doctorRepository = new Repository(
                
                );*/
         
        }
    }
}
