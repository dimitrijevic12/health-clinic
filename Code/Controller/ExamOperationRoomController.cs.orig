using health_clinicClassDiagram.Service;
using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Controller
{
    public class ExamOperationRoomController : IExamOperationRoomController
    {
        private static ExamOperationRoomController instance;
<<<<<<< HEAD
        

=======


>>>>>>> master
        private readonly IExamOperationRoomService _service = ExamOperationRoomService.Instance;

        public static ExamOperationRoomController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExamOperationRoomController();
                }
                return instance;
            }
        }

        private ExamOperationRoomController()
        {

        }

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

            var rooms = (List<ExamOperationRoom>)_service.GetAll();
            return rooms;
        }

        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }
    }

}
