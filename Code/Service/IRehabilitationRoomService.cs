using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Service
{
    public interface IRehabilitationRoomService : IService<RehabilitationRoom>
    {
        Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
        List<Patient> GetAllPatientsByRoom(Model.Rooms.Room room);
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);

        RehabilitationRoom getRoom(RehabilitationRoom room);
    }
}
