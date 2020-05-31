/***********************************************************************
 * Module:  EquipInventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipInventoryService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public class EquipInventoryService : IEquipInvetoryService
   {
      public EquipInventoryService GetInstance() { return null; }
        public bool MoveInventory(Room roomFrom, Room roomTo, InventoryEquip inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public void AddAmmount(InventoryEquip inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEquip> GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip Create(InventoryEquip obj)
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

        List<InventoryEquip> IEquipInvetoryService.GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public Repository.IEquipInvetoryRepository iEquipInvetoryRepository;
   
      private static EquipInventoryService Instance;
   
   }
}