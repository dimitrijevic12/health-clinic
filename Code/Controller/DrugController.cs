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
   public class DrugController : IDrugController
   {
        public IDrugService _service;

        private static DrugController Instance;

        public DrugController GetInstance(){ return null; }

        public DrugController(IDrugService service)
        {
            _service = service;
        }

        public List<Drug> GetAllDrugs()
        {
            var rooms = (List<Drug>)_service.GetAll();
            return rooms;
        }

        public void addDrug(String naziv, int quant)
        {
            _service.addDrug(naziv, quant);
        }

        public List<Drug> GetAll()
        {
            var rooms = (List<Drug>)_service.GetAll();
            return rooms;
        }

        public bool Delete(Drug obj)
        {
            return _service.Delete(obj);
        }

        public Drug Create(Drug obj)
        {
            return _service.Create(obj);
        }

        public Drug Edit(Drug obj)
        {
            return _service.Edit(obj);
        }

      
   
   }
}