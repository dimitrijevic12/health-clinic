/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class RoomService : IRoomService
   {
        private readonly IRoomRepository _roomRepository;

        private static RoomService Instance;

        public RoomService GetInstance() { return null; }

        public RoomService(IRoomRepository repository)
        {
            _roomRepository = repository;
        }
<<<<<<< HEAD

=======
>>>>>>> master
        public bool IsRoomFree(DateTime from, DateTime to, Room room)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAllPatientsByRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public bool AddPatient(Patient patient, Room room)
        {
            throw new NotImplementedException();
        }

        public Room Create(Room obj)
        {
            var newRoom = _roomRepository.Save(obj);

            return newRoom;
        }

        public Room Edit(Room obj)
        {
            var newRoom = _roomRepository.Edit(obj);

            return newRoom;
        }

        public bool Delete(Room obj)
        {
            var newRoom = _roomRepository.Delete(obj);

            return true;
        }

        public List<Room> GetAll()
        {
            var rooms = _roomRepository.GetAll();
            return rooms;
        }

<<<<<<< HEAD
       
=======
      
>>>>>>> master
   }
}