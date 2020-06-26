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
        public DrugController GetInstance(){ return null; }
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
        public List<Drug> GetAllDrugs()
        {
            return DrugService.Instance.GetAllDrugs();
        }

        public Service.IDrugService iDrugService;

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