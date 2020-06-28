﻿using Controller;
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

        RehabilitationRoom GetRoomById(long id);
        List<Patient> GetAllPatientsByRoom();
        int GenerateReport(Room room);
        Boolean AddPatient(MedicalRecord record, RehabilitationRoom room);
        Boolean ReleasePatient(MedicalRecord record, RehabilitationRoom room);
        RehabilitationRoom GetRoom(RehabilitationRoom room);
        Room IncreaseQuantity(Room room, Equipment equipment);

        Room DecreaseQuantity(Room room, Equipment equipment);
    }
}
