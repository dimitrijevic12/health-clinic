/***********************************************************************
 * Module:  IRoomController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IRoomController
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Controller
{
   public interface IRoomController : IController<Room>
   {
      Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
      List<Patient> GetAllPatientsByRoom();
      int GenerateReport(Model.Rooms.Room room);
      Boolean AddPatient(Model.SystemUsers.Patient patient);
   }
}