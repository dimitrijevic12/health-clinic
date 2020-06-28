/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class EquipmentController : IEquipmentController
   {
        private static EquipmentController instance = null;
        private readonly IEquipmentService _service = EquipmentService.Instance;

        public static EquipmentController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EquipmentController();
                }
                return instance;
            }
        }

        private EquipmentController()
        {

        }
        public List<Equipment> GetAll()
        {

            List<Equipment> equipments = (List<Equipment>)_service.GetAll();
            return equipments;

        }

        public bool Delete(Equipment obj)
        {
            return _service.Delete(obj);
        }

        public Equipment Create(Equipment obj)
        {
            return EquipmentService.Instance.Create(obj);
        }

        public Equipment Edit(Equipment obj)
        {
            return EquipmentService.Instance.Edit(obj);
        }

        public void addEquipment(string name, int quant)
        {
            _service.addEquipment(name, quant);
        }

        public void deleteEquipment(long Id, int quant)
        {
            _service.deleteEquipment(Id, quant);
        }

        public string getNazivOpreme(long Id)
        {
            return _service.getNazivOpreme(Id);
        }

        public long getIdOpreme(string name)
        {
            return _service.getIdOpreme(name);
        }
    }
}