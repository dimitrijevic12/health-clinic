/***********************************************************************
 * Module:  DoctorDrugController.cs
 * Author:  user
 * Purpose: Definition of the Class Controller.DoctorDrugController
 ***********************************************************************/

using Model.Rooms;
using Service;
using System;

namespace Controller
{
   public class DoctorDrugController : DecoratedDrugController
   {
        private static DoctorDrugController instance = null;

        public static DoctorDrugController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoctorDrugController();
                }
                return instance;
            }
        }

        private DoctorDrugController()
        {
        }

        public Drug ValidateDrug(Drug drug)
        {
            /* return DoctorDrugService.Instance.ValidateDrug(drug);*/
            throw new NotImplementedException();
        }

        public Drug LowerQuantity(Drug drug)
        {
            /*return DoctorDrugService.Instance.LowerQuantity(drug);*/
            throw new NotImplementedException();
        }

        public Drug IncreaseQuantity(Drug drug)
        {
            /*return DoctorDrugService.Instance.IncreaseQuantity(drug);*/
            throw new NotImplementedException();
        }

    }
}