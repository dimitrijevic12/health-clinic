/***********************************************************************
 * Module:  DrugCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.DrugCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository.Csv.Converter
{
   public class DrugCSVConverter : ICSVConverter<Drug>
   {
      private String Delimiter;

        public Drug ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Drug entity)
        {
            throw new NotImplementedException();
        }
    }
}