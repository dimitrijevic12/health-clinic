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
<<<<<<< HEAD
      
      private readonly string _delimiter;
      public RoomCSVConverter(string delimiter)
      {
          _delimiter = delimiter;
      }

=======
        private readonly string _delimiter;
        public RoomCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }
>>>>>>> master
        public Room ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());
            String tipString = tokens[2];

            TypeOfRoom tipS = (TypeOfRoom)Enum.Parse(typeof(TypeOfRoom), tipString, true);

            Room room = new Room(long.Parse(tokens[0]), tipS);
<<<<<<< HEAD
=======
            
>>>>>>> master
            return room;
        }

        public string ConvertEntityToCSVFormat(Room entity)
        {
            return string.Join(_delimiter,
<<<<<<< HEAD
                 entity.Id);
=======
                  entity.Id);
>>>>>>> master
        }
    }
}