/***********************************************************************
 * Module:  ReportCSVConverter.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.Csv.Converter.ReportCSVConverter
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository.Csv.Converter
{
   public class ReportCSVConverter : ICSVConverter<Appointment>
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