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
   public class DrugService : IDrugService
   {
        private static DrugService instance = null;
        public static DrugService Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new DrugService();
                }
                return instance;
            }
        }
        
        private DrugService()
        {

        }

        public List<Drug> GetAllDrugs()
        {
            return DrugRepository.Instance.GetAll();
        }


        public List<Drug> GetUnvalidatedDrugs()
        {
            List<Drug> unvalidatedDrugs = new List<Drug>();
            foreach(Drug drug in GetAllDrugs())
            {
                if (drug.Validation == false) unvalidatedDrugs.Add(drug);
            }

            return unvalidatedDrugs;
        }

        public List<Drug> GetValidatedDrugs()
        {
            List<Drug> unvalidatedDrugs = new List<Drug>();
            foreach (Drug drug in GetAllDrugs())
            {
                if (drug.Validation == true) unvalidatedDrugs.Add(drug);
            }

            return unvalidatedDrugs;
        }

    }
}