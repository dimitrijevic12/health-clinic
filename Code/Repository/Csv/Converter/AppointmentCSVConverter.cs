/***********************************************************************
 * Module:  AppointmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.AppointmentCSVConverter
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository.Csv.Converter
{
   public class AppointmentCSVConverter : ICSVConverter<Appointment>
   {
      private String Delimiter;

        public Appointment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Appointment entity)
        {
            throw new NotImplementedException();
        }
    }
}