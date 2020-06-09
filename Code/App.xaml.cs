using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Repository;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using Service;
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

        private const string DATETIME_FORMAT = "dd.MM.yyyy.";

        public App()
        {
            var appointmentRepository = new AppointmentRepository(
                APPOINTMENT_FILE,
                new CSVStream<Appointment>(APPOINTMENT_FILE, new AppointmentCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());

            var recordRepository = new MedicalRecordRepository(
                MEDICALRECORD_FILE,
                new CSVStream<MedicalRecord>(MEDICALRECORD_FILE, new MedicalRecordCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());

            var appointmentService = new AppointmentService;
            var recordService = new MedicalRecordService;
        }
    }
}
