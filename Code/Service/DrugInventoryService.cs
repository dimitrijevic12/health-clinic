/***********************************************************************
 * Module:  InventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.InventoryService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DrugInventoryService : IDrugInvetoryService
   {
      public DrugInventoryService GetInstance() { return null; }
        public bool MoveDrugInventory(Room roomFrom, Room roomTo, InventoryDrugs inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public void AddAmmount(InventoryDrugs inventory, int ammount)
        {
            throw new NotImplementedException();
        }

        public List<InventoryDrugs> GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs Create(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs Edit(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public List<InventoryDrugs> GetAll()
        {
            throw new NotImplementedException();
        }

        List<InventoryDrugs> IDrugInvetoryService.GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

        public Repository.IDrugInvetoryRepository iDrugInvetoryRepository;
   
      private static DrugInventoryService Instance;
   
   }
}