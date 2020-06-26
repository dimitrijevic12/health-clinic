using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Service
{
    public interface IRehabilitationRoomService : IService<RehabilitationRoom>
    {
        Boolean IsRoomFree(DateTime from, DateTime to, Room room);
        List<Patient> GetAllPatientsByRoom(Room room);
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);

        RehabilitationRoom findRehabRoom(long id);

        RehabilitationRoom getRoom(RehabilitationRoom room);

        Room IncreaseQuantity(Room r, Equipment eq);

        Room DecreaseQuantity(Room r, Equipment eq);
    }
}
