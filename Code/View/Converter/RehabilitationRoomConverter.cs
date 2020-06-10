using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.View.Converter
{
    class RehabilitationRoomConverter : AbstractConverter
    {
        public static string ConvertRehabilitationRoomToString(RehabilitationRoom room)
           => string.Join(" ", room, room.Patients);

        public static IList<string> ConvertRehabilitationRoomListToStringList(IList<RehabilitationRoom> rooms)
            => ConvertEntityListToViewList(rooms, ConvertRehabilitationRoomToString);
    }
}
