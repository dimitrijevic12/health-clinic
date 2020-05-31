/***********************************************************************
 * Module:  MedicalRecordCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.MedicalRecordCSVConverter
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository.Csv.Converter
{
   public class MedicalRecordCSVConverter : ICSVConverter<MedicalRecord>
   {
      private String Delimiter;

        public MedicalRecord ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }
    }
}