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