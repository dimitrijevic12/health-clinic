/***********************************************************************
 * Module:  DrugInvetoryCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.DrugInvetoryCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository.Csv.Converter
{
   public class DrugInvetoryCSVConverter : ICSVConverter<InventoryDrugs>
   {
      private String Delimiter;

        public InventoryDrugs ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(InventoryDrugs entity)
        {
            throw new NotImplementedException();
        }
    }
}