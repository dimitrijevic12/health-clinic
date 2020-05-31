/***********************************************************************
 * Module:  IRoomController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IRoomController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IRoomController : IController
   {
      Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
      List<Patient> GetAllPatientsByRoom();
      int GenerateReport(Model.Rooms.Room room);
      Boolean AddPatient(Model.SystemUsers.Patient patient);
   }
}