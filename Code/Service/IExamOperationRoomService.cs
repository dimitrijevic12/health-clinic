using Model.Rooms;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Service
{
    public interface IExamOperationRoomService : IService<ExamOperationRoom>
    {
        ExamOperationRoom findExamRoom(long id);

        Room IncreaseQuantity(Room r, Equipment eq);

        Room DecreaseQuantity(Room r, Equipment eq);
    }
}