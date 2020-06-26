/***********************************************************************
 * Module:  AppointmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.AppointmentCSVConverter
 ***********************************************************************/

using health_clinicClassDiagram.Repository;
using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Repository.Csv.Stream;
using System;

namespace Repository.Csv.Converter
{
   public class AppointmentCSVConverter : ICSVConverter<Appointment>
   {
        private String _delimiter;
        private readonly string _datetimeFormat;

        public AppointmentCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Appointment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            string doctorName = tokens[2];
            string doctorSurname = tokens[3];
            string patientName = tokens[4];
            string patientSurname = tokens[5];
            long patientId = long.Parse(tokens[6]);
            ExamOperationRoom room = new ExamOperationRoom(long.Parse(tokens[10]));
            TypeOfAppointment type = (TypeOfAppointment)Enum.Parse(typeof(TypeOfAppointment), tokens[7], true);
            DateTime startDate = DateTime.Parse(tokens[8]);
            DateTime endDate = DateTime.Parse(tokens[9]);
            //DateTime startDate = DateTime.Now;
            //DateTime endDate = DateTime.Now;

            //Patient patient = new Patient(tokens[0], tokens[1], int.Parse(tokens[2]));    //preskocimo prvi button select patient

            /*var doctorRepository = new DoctorRepository(
                "../../Resources/Data/doctors.csv",
                new CSVStream<Doctor>("../../Resources/Data/doctors.csv", new DoctorCSVConverter(",", "dd.MM.yyyy.")),
                new LongSequencer());

            var patientRepository = new PatientRepository(
                "../../Resources/Data/patients.csv",
                new CSVStream<Patient>("../../Resources/Data/patients.csv", new PatientCSVConverter(",", "dd.MM.yyyy.")),
                new LongSequencer());*/

            var doctorRepository = DoctorRepository.Instance;
            var patientRepository = PatientRepository.Instance;

            Doctor doctor = doctorRepository.GetDoctorById(long.Parse(tokens[1]));

            Patient patient = patientRepository.getPatientById(patientId);

            
            return new Appointment(long.Parse(tokens[0]),
               doctor,
                patient,
                room, 
                type,
                startDate,
                endDate); //tokens[6]
        }

        public string ConvertEntityToCSVFormat(Appointment entity)
             => string.Join(_delimiter,
               entity.Id,
               entity.Doctor.Id,
               entity.Doctor.Name,
               entity.Doctor.Surname,
               entity.Patient.Name,
               entity.Patient.Surname,
               entity.Patient.Id,
               entity.Type,
               entity.StartDate.ToString(),
               entity.EndDate.ToString(),
               entity.ExamOperationRoom.Id);
    }
}