using Controller;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Controller
{
    public interface IExamOperationRoomController : IController<ExamOperationRoom>
    {
        ExamOperationRoom findExamRoom(long id);

        Room IncreaseQuantity(Room r, Equipment eq);

        Room DecreaseQuantity(Room r, Equipment eq);
    }
}