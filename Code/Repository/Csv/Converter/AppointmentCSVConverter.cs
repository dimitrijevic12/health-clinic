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
            string doctorName = tokens[2];
            string doctorSurname = tokens[3];
            string patientName = tokens[4];
            string patientSurname = tokens[5];
            int patientId = int.Parse(tokens[6]);
            ExamOperationRoom room = new ExamOperationRoom(long.Parse(tokens[10]));
            TypeOfAppointment type = (TypeOfAppointment)Enum.Parse(typeof(TypeOfAppointment), tokens[7], true);
            DateTime startDate = DateTime.Parse(tokens[8]);
            DateTime endDate = DateTime.Parse(tokens[9]);
            //DateTime startDate = DateTime.Now;
            //DateTime endDate = DateTime.Now;

            //Patient patient = new Patient(tokens[0], tokens[1], int.Parse(tokens[2]));    //preskocimo prvi button select patient

            return new Appointment(long.Parse(tokens[0]),
               new Doctor(long.Parse(tokens[1]), doctorName, doctorSurname), //doctor tokens[4]
                new Patient(patientName, patientSurname, patientId),
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