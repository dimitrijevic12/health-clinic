/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class EquipmentService : IEquipmentService
   {
        private static EquipmentService instance = null;
        public IEquipRepository _equipmentRepository = EquipRepository.Instance;
        public static EquipmentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EquipmentService();
                }
                return instance;
            }
        }

        private EquipmentService()
        {

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

        public void addEquipment(string naziv, int quant)
        {
            bool postoji = _equipmentRepository.EquipExists(naziv);
            if (postoji)
            {
                var Foundequip = _equipmentRepository.GetEquip(naziv);
                Foundequip.Quantity += quant;
                _equipmentRepository.Edit(Foundequip);
            }
            else
            {
                Equipment d = new Equipment(naziv, quant);
                var newDrag = _equipmentRepository.Save(d);
            }

        }

        public void deleteEquipment(int Id, int quant)
        {
            bool postoji = _equipmentRepository.EquipExists(Id);
            if (postoji)
            {
                var Foundequip = _equipmentRepository.GetEquip(Id);
                Foundequip.Quantity -= quant;
                _equipmentRepository.Edit(Foundequip);
            }
        }

        public string getNazivOpreme(int Id)
        {
            var eqs = _equipmentRepository.GetAll();
            foreach (Equipment e in eqs)
            {
                if (e.Id == Id)
                {
                    return e.Naziv;
                    break;
                }
            }
            return "ne postoji";
        }

        public int getIdOpreme(string naziv)
        {
            var eqs = _equipmentRepository.GetAll();
            foreach (Equipment e in eqs)
            {
                if (e.Naziv.Equals(naziv))
                {
                    return e.Id;
                    break;
                }
            }
            return 0;
        }


    }
}