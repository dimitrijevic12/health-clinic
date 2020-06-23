/***********************************************************************
 * Module:  InventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.InventoryService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DrugInventoryService : IDrugInvetoryService
   {
        public Repository.IDrugInvetoryRepository _drugRepository;

        private static DrugInventoryService Instance;
        public DrugInventoryService GetInstance() { return null; }

        public DrugInventoryService(IDrugInvetoryRepository repository)
        {
            _drugRepository = repository;
        }
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
            var newEquip = _drugRepository.Save(obj);


            return newEquip;
        }

        public InventoryDrugs Edit(InventoryDrugs obj)
        {
            _drugRepository.Edit(obj);
            return obj;
        }

        public bool Delete(InventoryDrugs obj)
        {
            _drugRepository.Delete(obj);
            return true;
        }

        public List<InventoryDrugs> GetAll()
        {
            var rooms = _drugRepository.GetAll();
            return rooms;
        }

        List<InventoryDrugs> IDrugInvetoryService.GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

       
   
   }
}