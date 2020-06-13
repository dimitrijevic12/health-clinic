/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Controller;
using Model.Rooms;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class EquipmentService : IEquipmentService
   {
        public IEquipRepository _equipmentRepository;

        private static EquipmentService Instance;

        public EquipmentService GetInstance() { return null; }

        public EquipmentService(IEquipRepository repository)
        {
            _equipmentRepository = repository;
        }

        public Equipment Create(Equipment obj)
        {
            var newEquip = _equipmentRepository.Save(obj);


            return newEquip;
        }

        public Equipment Edit(Equipment obj)
        {
            _equipmentRepository.Edit(obj);
            return obj;
        }

        public bool Delete(Equipment obj)
        {
            _equipmentRepository.Delete(obj);
            return true;
        }

        public List<Equipment> GetAll()
        {
            var rooms = _equipmentRepository.GetAll();
            return rooms;
        }

        public void addEquipment(int idE, int quant)
        {
            var Foundequip = _equipmentRepository.GetEquip(idE);
            Foundequip.Quantity += quant;
            _equipmentRepository.Edit(Foundequip);


        }

        /* public void addEquipment(TypeOfEquipment tip, int quantity)
         {
             var eq = _equipmentRepository.GetAll();
             for (Equipment e : eq)
             {

             }

         }*/



    }
}