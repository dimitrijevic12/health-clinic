using Controller;
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
    public interface IRehabilitationRoomController : IController<RehabilitationRoom>
    {
<<<<<<< HEAD
        Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
        List<Patient> GetAllPatientsByRoom();
        int GenerateReport(Model.Rooms.Room room);
=======
        Boolean IsRoomFree(DateTime from, DateTime to, Room room);
        List<Patient> GetAllPatientsByRoom();
        int GenerateReport(Room room);
>>>>>>> master
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);

        RehabilitationRoom getRoom(RehabilitationRoom room);
    }
<<<<<<< HEAD
    
=======
>>>>>>> master
}
