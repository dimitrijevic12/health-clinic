/***********************************************************************
 * Module:  InventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.InventoryService
 ***********************************************************************/

using Model.Rooms;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class EquipInventoryController : IEquipInvetoryController
   {
        public Service.IEquipInvetoryService _service;

        private static EquipInventoryController Instance;
        public EquipInventoryController GetInstance() { return null; }
        public EquipInventoryController(IEquipInvetoryService service)
        {
            _service = service;
        }
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
            var rooms = (List<InventoryEquip>)_service.GetAll();
            return rooms;
        }

        public bool Delete(InventoryEquip obj)
        {
            return _service.Delete(obj);
        }

        public InventoryEquip Create(InventoryEquip obj)
        {
            return _service.Create(obj);
        }

        public InventoryEquip Edit(InventoryEquip obj)
        {
            return _service.Edit(obj);
        }

       
   
   }
}