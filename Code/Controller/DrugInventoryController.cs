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
   public class DrugInventoryController : IDrugInvetoryController
   {
        public Service.IDrugInvetoryService _service;

        private static DrugInventoryController Instance;

        public DrugInventoryController GetInstance() { return null; }

        public DrugInventoryController(IDrugInvetoryService service)
        {
            _service = service;
        }

        public bool MoveDrugInventory(Room roomFrom, Room roomTo, InventoryDrugs inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public void AddAmmount(InventoryDrugs inventory, int ammount, Drug drug)
        {
            throw new NotImplementedException();
        }

        public List<InventoryDrugs> GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public List<InventoryDrugs> GetAll()
        {
            var rooms = (List<InventoryDrugs>)_service.GetAll();
            return rooms;
        }

        public bool Delete(InventoryDrugs obj)
        {
            return _service.Delete(obj);
        }

        public InventoryDrugs Create(InventoryDrugs obj)
        {
            return _service.Create(obj);
        }

        public InventoryDrugs Edit(InventoryDrugs obj)
        {
            return _service.Edit(obj);
        }

      
   
   }
}