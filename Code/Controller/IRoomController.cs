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
      Boolean IsRoomFree(DateTime from, DateTime to);
      Model.SystemUsers.Patient[] GetAllPatientsByRoom();
      int GenerateReport();
      Boolean AddPatient(Model.SystemUsers.Patient patient);
   }
}