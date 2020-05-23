/***********************************************************************
 * Module:  InventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.InventoryService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public class DrugInventoryController : IDrugInvetoryController
   {
      public Service.DrugInventoryService drugInventoryService;

        public void AddAmmount(InventoryDrugs inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs Create(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs Edit(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs GetAll()
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs[] GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public bool MoveDrugInventory(Room roomFrom, Room roomTo, InventoryDrugs inventory, int ammount)
        {
            throw new NotImplementedException();
        }
    }
}