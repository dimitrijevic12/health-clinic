/***********************************************************************
 * Module:  InventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.InventoryService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class EquipInventoryController : IEquipInvetoryController
   {
        public EquipInventoryController GetInstance() { return null; }
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

        public List<InventoryEquip> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(InventoryEquip obj)
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

        public Service.IEquipInvetoryService iEquipInvetoryService;
   
      private static EquipInventoryController Instance;
   
   }
}