/***********************************************************************
 * Module:  EquipInventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipInventoryService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class EquipInventoryService : IEquipInvetoryService
   {
        public Repository.IEquipInvetoryRepository _drugRepository;

        private static EquipInventoryService Instance;
        public EquipInventoryService GetInstance() { return null; }

        public EquipInventoryService(IEquipInvetoryRepository repository)
        {
            _drugRepository = repository;
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

        public InventoryEquip Create(InventoryEquip obj)
        {
            var newEquip = _drugRepository.Save(obj);


            return newEquip;
        }

        public InventoryEquip Edit(InventoryEquip obj)
        {
            _drugRepository.Edit(obj);
            return obj;
        }

        public bool Delete(InventoryEquip obj)
        {
            _drugRepository.Delete(obj);
            return true;
        }

        public List<InventoryEquip> GetAll()
        {
            var rooms = _drugRepository.GetAll();
            return rooms;
        }

        List<InventoryEquip> IEquipInvetoryService.GetInventory(Room room)
        {
            throw new NotImplementedException();
        }

       
   
   }
}