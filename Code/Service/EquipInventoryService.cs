/***********************************************************************
 * Module:  EquipInventoryService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.EquipInventoryService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public class EquipInventoryService : IEquipInvetoryService
   {
      public Repository.EquipInventoryRepository equipInventoryRepository;

        public void AddAmmount(InventoryEquip inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip Create(InventoryEquip obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InventoryEquip obj)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip Edit(InventoryEquip obj)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip[] GetAll()
        {
            throw new NotImplementedException();
        }

        public InventoryEquip[] GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public bool MoveInventory(Room roomFrom, Room roomTo, InventoryEquip inventory, int ammount)
        {
            throw new NotImplementedException();
        }
    }
}