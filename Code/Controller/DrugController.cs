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
        private static DrugController instance = null;
        public static DrugController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DrugController();
                }
                return instance;
            }
        }

        private DrugController()
        {

        }

        public void addDrug(String naziv, int quant)
        {
            DrugService.Instance.addDrug(naziv, quant);
        }

        public bool Delete(Drug obj)
        {
            return DrugService.Instance.Delete(obj);
        }

        public Drug Create(Drug obj)
        {
            return DrugService.Instance.Create(obj);
        }

        public Drug Edit(Drug obj)
        {
            return DrugService.Instance.Edit(obj);
        }
        public List<Drug> GetAll()
        {

            var rooms = (List<Drug>)DrugService.Instance.GetAll();
            return rooms;
        }
        public List<Drug> GetAllDrugs()
        {
            return DrugService.Instance.GetAllDrugs();
        }

        public List<Drug> GetUnvalidatedDrugs()
        {
            return DrugService.Instance.GetUnvalidatedDrugs();
        }

        public List<Drug> GetValidatedDrugs()
        {
            return DrugService.Instance.GetValidatedDrugs();
        }


    }
}