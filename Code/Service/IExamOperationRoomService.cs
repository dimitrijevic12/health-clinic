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
        Boolean IsRoomFree(DateTime from, DateTime to, Room room);
    }
}
