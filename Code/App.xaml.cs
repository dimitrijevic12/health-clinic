using Model.Appointment;
using Repository;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace health_clinicClassDiagram
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        private const string APPOINTMENT_FILE = "../../Resources/Data/appointments.csv";
        private const string MEDICALRECORD_FILE = "../../Resources/Data/records.csv";
        private const string CSV_DELIMITER = ",";

        public App()
        {
            var appointmentRepository = new AppointmentRepository(
                APPOINTMENT_FILE,
                new CSVStream<Appointment>(new AccountCSVConverter(CSV_DELIMITER))
                )
        }
    }
}
