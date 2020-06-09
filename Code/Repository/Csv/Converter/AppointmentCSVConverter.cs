/***********************************************************************
 * Module:  AppointmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.AppointmentCSVConverter
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using System;

namespace Repository.Csv.Converter
{
   public class AppointmentCSVConverter : ICSVConverter<Appointment>
   {
<<<<<<< HEAD
      private String _delimiter;
=======
        private String _delimiter;
>>>>>>> master
        private readonly string _datetimeFormat;

        public AppointmentCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Appointment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

            Patient patient = new Patient(tokens[1], tokens[2], int.Parse(tokens[3]));    //preskocimo prvi button select patient

            return new Appointment(
               new Doctor(), //doctor tokens[4]
<<<<<<< HEAD
                patient, 
                TypeOfAppointment.EXAM); //tokens[6]
        }

        public string ConvertEntityToCSVFormat(Appointment entity)       
             => string.Join(_delimiter,             
               entity.doctor,
               entity.patient,
               entity.Type);
        
=======
                patient,
                TypeOfAppointment.EXAM); //tokens[6]
        }

        public string ConvertEntityToCSVFormat(Appointment entity)
             => string.Join(_delimiter,
               entity.doctor,
               entity.patient,
               entity.Type);
>>>>>>> master
    }
}