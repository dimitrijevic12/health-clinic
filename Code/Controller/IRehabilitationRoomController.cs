using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Controller
{
    public interface IRehabilitationRoomController : IController<RehabilitationRoom>
    {
        Boolean IsRoomFree(DateTime from, DateTime to, Room room);
        List<Patient> GetAllPatientsByRoom();
        int GenerateReport(Room room);
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);
        Boolean releasePatient(MedicalRecord record, RehabilitationRoom room);
        RehabilitationRoom getRoom(RehabilitationRoom room);
        Room IncreaseQuantity(Room r, Equipment eq);

        Room DecreaseQuantity(Room r, Equipment eq);

        RehabilitationRoom findRehabRoom(long id);
    }
}
