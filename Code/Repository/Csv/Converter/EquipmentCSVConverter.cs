/***********************************************************************
 * Module:  EquipmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.EquipmentCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository.Csv.Converter
{
   public class EquipmentCSVConverter : ICSVConverter<Equipment>
   {
      private String Delimiter;

        public Equipment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Equipment entity)
        {
            throw new NotImplementedException();
        }
    }
}