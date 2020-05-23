/***********************************************************************
 * Module:  IRoomService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IRoomService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public interface IRoomService : IService<Room>
   {
      Boolean IsRoomFree(DateTime from, DateTime to);
      Model.SystemUsers.Patient[] GetAllPatientsByRoom();
      int GenerateReport();
      Boolean AddPatient(Model.SystemUsers.Patient patient);
   }
}