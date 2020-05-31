/***********************************************************************
 * Module:  RoomCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.RoomCSVConverter
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository.Csv.Converter
{
   public class RoomCSVConverter : ICSVConverter<Room>
   {
      private String Delimiter;

        public Room ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Room entity)
        {
            throw new NotImplementedException();
        }
    }
}