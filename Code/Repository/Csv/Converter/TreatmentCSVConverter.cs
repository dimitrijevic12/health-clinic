/***********************************************************************
 * Module:  TreatmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.TreatmentCSVConverter
 ***********************************************************************/

using Model.Treatment;
using System;

namespace Repository.Csv.Converter
{
   public class TreatmentCSVConverter : ICSVConverter<Treatment>
   {
      private String Delimiter;

        public Treatment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Treatment entity)
        {
            throw new NotImplementedException();
        }
    }
}