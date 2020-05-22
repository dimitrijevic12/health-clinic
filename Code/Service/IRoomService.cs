/***********************************************************************
 * Module:  IRoomService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IRoomService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IRoomService : IService
   {
      Boolean IsRoomFree(DateTime from, DateTime to);
      Model.SystemUsers.Patient[] GetAllPatientsByRoom();
      int GenerateReport();
      Boolean AddPatient(Model.SystemUsers.Patient patient);
   }
}