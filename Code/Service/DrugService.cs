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
        public IDrugRepository _drugRepository = DrugRepository.Instance;
        public static DrugService Instance
        {
            get
            {
                if (instance == null)
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
            foreach (Drug drug in GetAllDrugs())
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

        public void addDrug(String naziv, int quant)
        {
            bool postoji = _drugRepository.DrugExists(naziv);
            if (postoji)
            {
                var Foundequip = _drugRepository.GetDrug(naziv);
                Foundequip.Quantity += quant;
                _drugRepository.Edit(Foundequip);
            }
            else
            {
                Drug d = new Drug(naziv, quant);
                var newDrag = _drugRepository.Save(d);
            }
        }

        public Drug Create(Drug obj)
        {
            var newEquip = _drugRepository.Save(obj);


            return newEquip;
        }
        public Drug Edit(Drug obj)
        {
            _drugRepository.Edit(obj);
            return obj;
        }
        public bool Delete(Drug obj)
        {
            _drugRepository.Delete(obj);
            return true;
        }
        public List<Drug> GetAll()
        {
            var rooms = _drugRepository.GetAll();
            return rooms;
        }

    }
}