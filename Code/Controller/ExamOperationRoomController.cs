using health_clinicClassDiagram.Service;
using Model.Rooms;

using Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;


namespace health_clinicClassDiagram.Controller
{
    public class ExamOperationRoomController : IExamOperationRoomController
    {
        private static ExamOperationRoomController instance;


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

        public ExamOperationRoom findExamRoom(long id)
        {
            return _service.findExamRoom(id);
        }

        public Room IncreaseQuantity(Room r, Equipment eq)
        {
            return _service.IncreaseQuantity(r, eq);
        }

        public Room DecreaseQuantity(Room r, Equipment eq)
        {
            return _service.DecreaseQuantity(r, eq);
        }

    }

}
