/***********************************************************************
 * Module:  NotificationCSVConverter.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.Csv.Converter.NotificationCSVConverter
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository.Csv.Converter
{
   public class NotificationCSVConverter : ICSVConverter<Notification>
   {
      private String Delimiter;

        public Notification ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}