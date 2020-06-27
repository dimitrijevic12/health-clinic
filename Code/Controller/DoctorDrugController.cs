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
            return null;
            //return DoctorDrugService.Instance.ValidateDrug(drug);
        }

        public Drug LowerQuantity(Drug drug)
        {
            return null;
            //return DoctorDrugService.Instance.LowerQuantity(drug);
        }

        public Drug IncreaseQuantity(Drug drug)
        {
            return null;
            //return DoctorDrugService.Instance.IncreaseQuantity(drug);
        }

    }
}