using health_clinicClassDiagram.Service;
using Model.Rooms;
<<<<<<< HEAD
using Service;
=======
>>>>>>> master
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> master

namespace health_clinicClassDiagram.Controller
{
    public class ExamOperationRoomController : IExamOperationRoomController
    {
        private static ExamOperationRoomController Instance;
        public ExamOperationRoomController GetInstance() { return null; }

        private readonly IExamOperationRoomService _service;

        public ExamOperationRoomController(IExamOperationRoomService service)
        {
            _service = service;
        }


        public ExamOperationRoom Create(ExamOperationRoom obj)
        {
            return _service.Create(obj);
        }

        public bool Delete(ExamOperationRoom obj)
        {
            return _service.Delete(obj);
        }

        public ExamOperationRoom Edit(ExamOperationRoom obj)
        {
            return _service.Edit(obj);
        }

        public List<ExamOperationRoom> GetAll()
        {
<<<<<<< HEAD
            
=======

>>>>>>> master
            var rooms = (List<ExamOperationRoom>)_service.GetAll();
            return rooms;
        }

        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }
    }
<<<<<<< HEAD
=======

>>>>>>> master
}
