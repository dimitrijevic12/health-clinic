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
   public class EquipInventoryRepository : IEquipInvetoryRepository
   {
      public EquipInventoryRepository GetInstance() { return null; }

        public InventoryEquip GetEquipInv(InventoryEquip invEquip)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip Save(InventoryEquip obj)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip Edit(InventoryEquip obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InventoryEquip obj)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEquip> GetAll()
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
      private static EquipInventoryRepository Instance;
   
   }
}