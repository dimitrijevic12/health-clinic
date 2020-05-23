/***********************************************************************
 * Module:  IRoomController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IRoomController
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public interface IRoomController : IController<Room>
   {
      Boolean IsRoomFree(DateTime from, DateTime to);
      Model.SystemUsers.Patient[] GetAllPatientsByRoom();
      int GenerateReport();
      Boolean AddPatient(Model.SystemUsers.Patient patient);
   }
}