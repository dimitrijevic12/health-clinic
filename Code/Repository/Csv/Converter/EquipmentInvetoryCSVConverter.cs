/***********************************************************************
 * Module:  EquipmentInvetoryCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.EquipmentInvetoryCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository.Csv.Converter
{
   public class EquipmentInvetoryCSVConverter : ICSVConverter<InventoryEquip>
   {
      private String Delimiter;

        public InventoryEquip ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(InventoryEquip entity)
        {
            throw new NotImplementedException();
        }
    }
}