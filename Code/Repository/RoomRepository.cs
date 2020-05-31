/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class RoomRepository : IRoomRepository
   {
      public RoomRepository GetInstance() { return null; }

        public Room GetRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Room Save(Room obj)
        {
            throw new NotImplementedException();
        }

        public Room Edit(Room obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Room obj)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        private String Path;
      private static RoomRepository Instance;
   
   }
}