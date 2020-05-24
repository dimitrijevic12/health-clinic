/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using System;

namespace Controller
{
   public class RoomController : IRoomController
   {
      public Service.RoomService roomService;

        public bool AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Room Create(Room obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Room obj)
        {
            throw new NotImplementedException();
        }

        public Room Edit(Room obj)
        {
            throw new NotImplementedException();
        }

        public int GenerateReport()
        {
            throw new NotImplementedException();
        }

        public Room[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Patient[] GetAllPatientsByRoom()
        {
            throw new NotImplementedException();
        }

        public bool IsRoomFree(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}