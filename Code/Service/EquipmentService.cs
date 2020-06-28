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

        public void addEquipment(string name, int quant)
        {
            bool postoji = _equipmentRepository.EquipExists(name);
            if (postoji)
            {
                var Foundequip = _equipmentRepository.GetEquip(name);
                Foundequip.Quantity += quant;
                _equipmentRepository.Edit(Foundequip);
            }
            else
            {
                Equipment d = new Equipment(LongRandom(0, 100000, new Random()),name, quant);
                var newDrag = _equipmentRepository.Save(d);
            }

        }

        public void deleteEquipment(long Id, int quant)
        {
            bool postoji = _equipmentRepository.EquipExists(Id);
            if (postoji)
            {
                var Foundequip = _equipmentRepository.GetEquip(Id);
                Foundequip.Quantity -= quant;
                _equipmentRepository.Edit(Foundequip);
            }
        }

        public string getNazivOpreme(long Id)
        {
            var eqs = _equipmentRepository.GetAll();
            foreach(Equipment e in eqs)
            {
                if(e.Id == Id)
                {
                    return e.Name;
                    
                }
            }
            return "ne postoji";
        }

        public long getIdOpreme(string name)
        {
            var eqs = _equipmentRepository.GetAll();
            foreach (Equipment e in eqs)
            {
                if (e.Name.Equals(name))
                {
                    return e.Id;
                    
                }
            }
            return 0;
        }
        private long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

    }
}