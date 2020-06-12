/***********************************************************************
 * Module:  AppointmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.AppointmentCSVConverter
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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
            string doctorName = tokens[1];
            string doctorSurname = tokens[2];
            string patientName = tokens[3];
            string patientSurname = tokens[4];
            int patientId = int.Parse(tokens[5]);
            ExamOperationRoom room = new ExamOperationRoom();
            TypeOfAppointment type = (TypeOfAppointment)Enum.Parse(typeof(TypeOfAppointment), tokens[6], true);
            DateTime startDate = DateTime.Parse(tokens[7]);
            DateTime endDate = DateTime.Parse(tokens[8]);

            //Patient patient = new Patient(tokens[0], tokens[1], int.Parse(tokens[2]));    //preskocimo prvi button select patient

            return new Appointment(long.Parse(tokens[0]),
               new Doctor(doctorName, doctorSurname), //doctor tokens[4]
                new Patient(patientName, patientSurname, patientId),
                room, 
                type,
                startDate,
                endDate); //tokens[6]
        }

        public string ConvertEntityToCSVFormat(Appointment entity)
             => string.Join(_delimiter,
               entity.Id,
               entity.Doctor.Name,
               entity.Doctor.Surname,
               entity.Patient.Name,
               entity.Patient.Surname,
               entity.Patient.Id,
               entity.Type,
               entity.StartDate.ToString(),
               entity.EndDate.ToString());
    }
}