/***********************************************************************
 * Module:  DoctorDrugService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.DoctorDrugService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;

namespace Service
{
   public class DoctorDrugService : DecoratedDrugService
   {
        private static DoctorDrugService instance = null;

        public static DoctorDrugService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DoctorDrugService();
                }
                return instance;
            }
        }

        private DoctorDrugService()
        {

        }

        public Drug ValidateDrug(Drug drug)
        {
            Drug drugToValidate = DrugRepository.Instance.GetDrugById(drug.Id);
            drugToValidate.Validation = true;
            return DrugRepository.Instance.Edit(drugToValidate);
        }

        public Drug lowerQuantity(Drug drug)
        {
            Drug drugToEdit = DrugRepository.Instance.GetDrugById(drug.Id);
            drugToEdit.Quantity--;
            return DrugRepository.Instance.Edit(drugToEdit);
        }

    }
}