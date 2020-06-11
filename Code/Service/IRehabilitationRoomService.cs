<<<<<<< HEAD
﻿using Controller;
using Model.Appointment;
=======
﻿using Model.Appointment;
>>>>>>> master
using Model.Rooms;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> master

namespace health_clinicClassDiagram.Service
{
    public interface IRehabilitationRoomService : IService<RehabilitationRoom>
    {
<<<<<<< HEAD
        Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
        List<Patient> GetAllPatientsByRoom(Model.Rooms.Room room);
=======
        Boolean IsRoomFree(DateTime from, DateTime to, Room room);
        List<Patient> GetAllPatientsByRoom(Room room);
>>>>>>> master
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);

        RehabilitationRoom getRoom(RehabilitationRoom room);
    }
}
