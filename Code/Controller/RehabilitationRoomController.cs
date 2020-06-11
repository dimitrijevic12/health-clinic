using health_clinicClassDiagram.Service;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
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
    public class RehabilitationRoomController : IRehabilitationRoomController
    {
<<<<<<< HEAD

=======
>>>>>>> master
        private static RehabilitationRoomController instance;
        public RehabilitationRoomController GetInstance() { return null; }

        private readonly IRehabilitationRoomService _service;

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
<<<<<<< HEAD
            return _service.Delete(obj);           
=======
            return _service.Delete(obj);
>>>>>>> master
        }

        public RehabilitationRoom Edit(RehabilitationRoom obj)
        {
<<<<<<< HEAD
            return _service.Edit(obj);          
=======
            return _service.Edit(obj);
>>>>>>> master
        }

        public int GenerateReport(Room room)
        {
            throw new NotImplementedException();
        }

        public List<RehabilitationRoom> GetAll()
        {
            var rooms = (List<RehabilitationRoom>)_service.GetAll();
            return rooms;
        }

        public List<Patient> GetAllPatientsByRoom()
        {
            throw new NotImplementedException();
        }

        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }

        public RehabilitationRoom getRoom(RehabilitationRoom room)
        {
            return _service.getRoom(room);
        }
    }
}
