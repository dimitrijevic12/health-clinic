/***********************************************************************
 * Module:  DoctorDrugService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.DoctorDrugService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DoctorDrugService : DecoratedDrugService
    {
        private DoctorDrugService(IDrugService decoratedDrug) : base(decoratedDrug)
        {   
        }

        public List<Drug> GetAllDrugs()
        {
            return base.GetAllDrugs();
        }

        public Drug ValidateDrug(Drug drug)
        {
            Drug drugToValidate = DrugRepository.Instance.GetDrugById(drug.Id);
            drugToValidate.Validation = true;
            return DrugRepository.Instance.Edit(drugToValidate);
        }

        public Drug LowerQuantity(Drug drug)
        {
            Drug drugToEdit = DrugRepository.Instance.GetDrugById(drug.Id);
            drugToEdit.Quantity--;
            return DrugRepository.Instance.Edit(drugToEdit);
        }

        public Drug IncreaseQuantity(Drug drug)
        {
            Drug drugToEdit = DrugRepository.Instance.GetDrugById(drug.Id);
            drugToEdit.Quantity++;
            return DrugRepository.Instance.Edit(drugToEdit);
        }

    }
}