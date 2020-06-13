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
        private readonly IEquipmentService _service;

        private static EquipmentController Instance;
        public EquipmentController GetInstance() { return null; }

        public EquipmentController(IEquipmentService service)
        {
            _service = service;
        }

        public List<Equipment> GetAll()
        {
            var rooms = (List<Equipment>)_service.GetAll();
            return rooms;
        }

        public bool Delete(Equipment obj)
        {
            return _service.Delete(obj);
        }

        public Equipment Create(Equipment obj)
        {
            return _service.Create(obj);
        }

        public Equipment Edit(Equipment obj)
        {
            return _service.Edit(obj);
        }

        public void addEquipment(int idE, int quant)
        {
           _service.addEquipment(idE,quant);
        }



    }
}