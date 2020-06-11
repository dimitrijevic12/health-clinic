/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RoomController : IRoomController
   {
       private readonly Service.IRoomService _service;

        private static RoomController Instance;

        public RoomController GetInstance() { return null; }

        public RoomController(IRoomService service)
        {
            _service = service;
        }

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
            var rooms = (List<Room>)_service.GetAll();
            return rooms;
        }

        public bool Delete(Room obj)
        {
            return _service.Delete(obj);
        }

        public Room Create(Room obj)
        {
             return _service.Create(obj);
        }

        public Room Edit(Room obj)
        {
            return _service.Edit(obj);
        }

       
   
   }
}