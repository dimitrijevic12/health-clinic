/***********************************************************************
 * Module:  RoomService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using System;

namespace Service
{
   public class RoomService : IRoomService
   {
      public Repository.RoomRepository roomRepository;

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