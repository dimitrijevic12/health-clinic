/***********************************************************************
 * Module:  RenovationCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.RenovationCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository.Csv.Converter
{
   public class RenovationCSVConverter : ICSVConverter<Renovation>
   {
      private String Delimiter;

        public Renovation ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Renovation entity)
        {
            throw new NotImplementedException();
        }
    }
}