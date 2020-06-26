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
            long patientId = long.Parse(tokens[2]);
            ExamOperationRoom room = new ExamOperationRoom(long.Parse(tokens[6]));
            TypeOfAppointment type = (TypeOfAppointment)Enum.Parse(typeof(TypeOfAppointment), tokens[3], true);
            DateTime startDate = DateTime.Parse(tokens[4]);
            DateTime endDate = DateTime.Parse(tokens[5]);         

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
                endDate); 
        }

        public string ConvertEntityToCSVFormat(Appointment entity)
             => string.Join(_delimiter,
               entity.Id,
               entity.Doctor.Id,
               entity.Patient.Id,
               entity.Type,
               entity.StartDate.ToString(),
               entity.EndDate.ToString(),
               entity.ExamOperationRoom.Id);
    }
}