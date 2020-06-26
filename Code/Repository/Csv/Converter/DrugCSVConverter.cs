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
        private readonly string _delimiter;


        public DrugCSVConverter(string delimiter)
        {
            _delimiter = delimiter;

        }
        public Drug ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());



            Drug eq = new Drug(int.Parse(tokens[0]), tokens[1], int.Parse(tokens[2]));
            return eq;
        }

        public string ConvertEntityToCSVFormat(Drug entity)
        {
            return string.Join(_delimiter,
                 entity.Id,
                 entity.Name,
                 entity.Quantity,
                 entity.Validation
                 );
        }
    }
}