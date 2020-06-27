using health_clinicClassDiagram.Service;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Controller
{
    public class RehabilitationRoomController : IRehabilitationRoomController
    {
        private readonly IRehabilitationRoomService _service = RehabilitationRoomService.Instance;

        private static RehabilitationRoomController instance;

        public static RehabilitationRoomController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RehabilitationRoomController();
                }
                return instance;
            }
        }

        private RehabilitationRoomController() { }


        public RehabilitationRoomController(IRehabilitationRoomService service)
        {
            _service = service;
        }

        public bool AddPatient(MedicalRecord record, RehabilitationRoom room)
        {
            return _service.AddPatient(record, room);
        }

        public RehabilitationRoom Create(RehabilitationRoom obj)
        {
            return _service.Create(obj);
        }

        public bool Delete(RehabilitationRoom obj)
        {
            return _service.Delete(obj);
        }

        public RehabilitationRoom Edit(RehabilitationRoom obj)
        {
            return _service.Edit(obj);
        }

        public List<RehabilitationRoom> GetAll()
        {
            var rooms = (List<RehabilitationRoom>)_service.GetAll();
            return rooms;
        }

        public RehabilitationRoom getRoom(RehabilitationRoom room)
        {
            return _service.GetRoom(room);
        }

        public bool releasePatient(MedicalRecord record, RehabilitationRoom room)
        {
            return _service.ReleasePatient(record, room);
        }

        public Room IncreaseQuantity(Room r, Equipment eq)
        {
            return _service.IncreaseQuantity(r, eq);
        }

        public Room DecreaseQuantity(Room r, Equipment eq)
        {
            return _service.DecreaseQuantity(r, eq);
        }

        public RehabilitationRoom findRehabRoom(long id)
        {
            return _service.findRehabRoom(id);
        }
    }
}
