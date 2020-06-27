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
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);
        Boolean ReleasePatient(MedicalRecord record, RehabilitationRoom room);
        RehabilitationRoom GetRoom(RehabilitationRoom room);
        RehabilitationRoom findRehabRoom(long id);
        Room IncreaseQuantity(Room r, Equipment eq);
        Room DecreaseQuantity(Room r, Equipment eq);
    }
}
