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
        Boolean IsRoomFree(DateTime from, DateTime to, Room room);
    }
}
