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
      
      private readonly string _delimiter;
      public RoomCSVConverter(string delimiter)
      {
          _delimiter = delimiter;
      }

        public Room ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            Room room = new Room(long.Parse(tokens[0]));
            return room;
        }

        public string ConvertEntityToCSVFormat(Room entity)
        {
            return string.Join(_delimiter,
                 entity.Id);
        }
    }
}