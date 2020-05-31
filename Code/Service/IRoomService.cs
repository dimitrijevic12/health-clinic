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
      Boolean IsRoomFree(DateTime from, DateTime to, Model.Rooms.Room room);
      List<Patient> GetAllPatientsByRoom(Model.Rooms.Room room);
      Boolean AddPatient(Model.SystemUsers.Patient patient, Model.Rooms.Room room);
   }
}