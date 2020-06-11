using Controller;
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
    public interface IRehabilitationRoomController : IController<RehabilitationRoom>
    {
        Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
        List<Patient> GetAllPatientsByRoom();
        int GenerateReport(Model.Rooms.Room room);
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);

        Boolean releasePatient(MedicalRecord record, RehabilitationRoom room);

        RehabilitationRoom getRoom(RehabilitationRoom room);
    }
    
}
