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
   public class EquipRepository : IEquipRepository
   {
      public EquipRepository GetInstance() { return null; }

        public Equipment GetEquip(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public Equipment Save(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Equipment Edit(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetAll()
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
      private static EquipRepository Instance;
   
   }
}