using Controller;
using health_clinicClassDiagram.Controller;
using health_clinicClassDiagram.Repository;
using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using health_clinicClassDiagram.Service;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Repository;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using Service;
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
        private const string EXAMOPERATIONROOM_FILE = "../../Resources/Data/examOperationRooms.csv";
        private const string REHABILITATIONROOM_FILE = "../../Resources/Data/rehabilitationRooms.csv";
        private const string USER_FILE = "../../Resources/Data/users.csv";
        private const string EQUIP_FILE = "../../Resources/Data/equipments.csv";
        private const string DRUGS_FILE = "../../Resources/Data/drugs.csv";
        private const string APPS_FILE = "../../Resources/Data/appointments.csv";
        private const string RENO_FILE = "../../Resources/Data/renovations.csv";
        private const string CSV_DELIMITER = ",";
        private const string DATETIME_FORMAT = "dd.MM.yyyy.";

        public IController<Doctor> doctorController { get; private set; }
        public IExamOperationRoomController examOperationRoomController { get; private set; }

        public IRoomController roomController { get; private set; }

        public IRehabilitationRoomController rehabilitationRoomController { get; private set; }

        public IEquipmentController equipController { get; private set; }

        public IDrugController drugController { get; private set; }

        public IAppointmentController appController { get; private set; }
        public IRenovationController renoController { get; private set; }

        public UserController userController { get; private set; }

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
           /* var doctorRepository = new DoctorRepository(
                DOCTOR_FILE,
                new CSVStream<Doctor>(DOCTOR_FILE, new DoctorCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());

            var examOperationRoomRepository = new ExamOperationRoomRepository(
                EXAMOPERATIONROOM_FILE,
                new CSVStream<ExamOperationRoom>(EXAMOPERATIONROOM_FILE, new ExamOperationRoomCSVConverter(CSV_DELIMITER)),
                new LongSequencer());

            *//* var rehabilitationRoomRepository = new RehabilitationRoomRepository(
                REHABILITATIONROOM_FILE,
                new CSVStream<Room>(REHABILITATIONROOM_FILE, new RehabilitationRoomCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());*//*

            var rehabilitationRoomRepository = new RehabilitationRoomRepository(
               REHABILITATIONROOM_FILE,
               new CSVStream<RehabilitationRoom>(REHABILITATIONROOM_FILE, new RehabilitationRoomCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
               new LongSequencer());


            var userRepository = new UserRepository(
              USER_FILE,
              new CSVStream<RegisteredUser>(USER_FILE, new UserCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
              new LongSequencer());

            var equipRepository = new EquipRepository(
              EQUIP_FILE,
              new CSVStream<Equipment>(EQUIP_FILE, new EquipmentCSVConverter(CSV_DELIMITER)),
              new LongSequencer());

            var drugRepository = new DrugRepository(
            DRUGS_FILE,
            new CSVStream<Drug>(DRUGS_FILE, new DrugCSVConverter(CSV_DELIMITER)),
            new LongSequencer());

            var appRepository = new AppointmentRepository(
            APPS_FILE,
            new CSVStream<Appointment>(APPS_FILE, new AppointmentCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
            new LongSequencer());

            var renoRepository = new RenovationRepository(
             RENO_FILE,
             new CSVStream<Renovation>(RENO_FILE, new RenovationCSVConverter(CSV_DELIMITER)),
             new LongSequencer());

            var doctorService = new DoctorService(doctorRepository);

            var examOperationRoomService = new ExamOperationRoomService(examOperationRoomRepository);
            var userService = new UserService(userRepository);

            var rehabilitationRoomService = new RehabilitationRoomService(rehabilitationRoomRepository, userService);

            var equipService = new EquipmentService(equipRepository);

            var drugsService = new DrugService(drugRepository);

            var appService = new AppointmentService(appRepository, doctorService, null, examOperationRoomService);

            var renoService = new RenovationService(renoRepository);


            examOperationRoomController = new ExamOperationRoomController(examOperationRoomService);
            doctorController = new DoctorController(doctorService);
            rehabilitationRoomController = new RehabilitationRoomController(rehabilitationRoomService);
            equipController = new EquipmentController(equipService);
            drugController = new DrugController(drugsService);
            appController = new AppointmentController(appService);
            renoController = new RenovationController(renoService);*/

        }
    }
}
