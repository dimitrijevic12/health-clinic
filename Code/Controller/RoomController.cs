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

        private readonly IRoomService _service = RoomService.Instance;

        private static RoomController instance;

        public static RoomController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomController();
                }
                return instance;
            }
        }

        private RoomController() { }
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

        public Room IncreaseQuantity(Room r, Equipment eq)
        {
            return _service.IncreaseQuantity(r, eq);
        }

        public Room DecreaseQuantity(Room r, Equipment eq)
        {
            return _service.DecreaseQuantity(r, eq);
        }
    }
}