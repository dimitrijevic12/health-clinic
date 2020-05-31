/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RoomController : IRoomController
   {
      public RoomController GetInstance() { return null; }
        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAllPatientsByRoom()
        {
            throw new NotImplementedException();
        }

        public int GenerateReport(Room room)
        {
            throw new NotImplementedException();
        }

        public bool AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Room obj)
        {
            throw new NotImplementedException();
        }

        public Room Create(Room obj)
        {
            throw new NotImplementedException();
        }

        public Room Edit(Room obj)
        {
            throw new NotImplementedException();
        }

        public Service.IRoomService iRoomService;
   
      private static RoomController Instance;
   
   }
}