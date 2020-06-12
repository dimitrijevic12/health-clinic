﻿using Controller;
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
using System.Runtime.Remoting.Messaging;
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
        private const string USER_FILE = "../../Resources/Data/users.csv";
        private const string REHABILATIONRROM_FILE = "../../Resources/Data/rehabilitationrooms.csv";
        private const string DOCTOR_FILE = "../../Resources/Data/doctors.csv";
        private const string TREATMENT_FILE = "../../Resources/Data/treatments.csv";
        private const string CSV_DELIMITER = ",";

        private const string DATETIME_FORMAT = "dd.MM.yyyy.";

        public IMedicalRecordController MedicalRecordController { get; private set; }
        public IAppointmentController AppointmentController { get; private set; }
        public IRehabilitationRoomController RehabilitationRoomController { get; private set; }
        public IUserController userController { get; private set; }
        public IController<Doctor> DoctorController { get; private set; }

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

            var userRepository = new UserRepository(
                USER_FILE,
                new CSVStream<RegisteredUser>(USER_FILE, new UserCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());

            var rehabilitationRoomRepository = new RehabilitationRoomRepository(
                REHABILATIONRROM_FILE,
                new CSVStream<RehabilitationRoom>(REHABILATIONRROM_FILE, new RehabilitationRoomCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());

            var doctorRepository = new DoctorRepository(
                DOCTOR_FILE,
                new CSVStream<Doctor>(DOCTOR_FILE, new DoctorCSVConverter(CSV_DELIMITER, DATETIME_FORMAT)),
                new LongSequencer());

           

            var userService = new UserService(userRepository);


            //var patientService = new UserService();

            var doctorService = new DoctorService(doctorRepository);
            var rehabilitationRoomService = new RehabilitationRoomService(rehabilitationRoomRepository, userService);
            var recordService = new MedicalRecordService(recordRepository, userService);
            var appointmentService = new AppointmentService(appointmentRepository, null, null, null);


            DoctorController = new DoctorController(doctorService);
            RehabilitationRoomController = new RehabilitationRoomController(rehabilitationRoomService);
            MedicalRecordController = new MedicalRecordController(recordService);
            AppointmentController = new AppointmentController(appointmentService);

        }
    }
}
