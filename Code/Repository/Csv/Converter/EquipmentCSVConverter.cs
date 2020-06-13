/***********************************************************************
 * Module:  EquipmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.EquipmentCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Windows.Controls.Primitives;

namespace Repository.Csv.Converter
{
   public class EquipmentCSVConverter : ICSVConverter<Equipment>
   {
        private readonly string _delimiter;


        public EquipmentCSVConverter(string delimiter)
        {
            _delimiter = delimiter;

        }

        public Equipment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            
            String tipString = tokens[0];
            TypeOfEquipment tip = (TypeOfEquipment)Enum.Parse(typeof(TypeOfEquipment), tipString, true);

            Equipment eq = new Equipment(int.Parse(tokens[0]),tip, int.Parse(tokens[2]));
            return eq;
        }

        public string ConvertEntityToCSVFormat(Equipment entity)
        {
            return string.Join(_delimiter,
                entity.Id,
                entity.Type,
                entity.Quantity
                );
        }
    }
}