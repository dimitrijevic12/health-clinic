/***********************************************************************
 * Module:  ReferralToHospitalTreatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.ReferralToHospitalTreatment
 ***********************************************************************/

using Model.Rooms;
using System;
<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
>>>>>>> master

namespace Model.Treatment
{
   public class ReferralToHospitalTreatment
   {
<<<<<<< HEAD
      public System.Collections.ArrayList drug;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDrug()
      {
         if (drug == null)
            drug = new System.Collections.ArrayList();
         return drug;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDrug(System.Collections.ArrayList newDrug)
      {
         RemoveAllDrug();
         foreach (Model.Rooms.Drug oDrug in newDrug)
            AddDrug(oDrug);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDrug(Model.Rooms.Drug newDrug)
      {
         if (newDrug == null)
            return;
         if (this.drug == null)
            this.drug = new System.Collections.ArrayList();
         if (!this.drug.Contains(newDrug))
            this.drug.Add(newDrug);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDrug(Model.Rooms.Drug oldDrug)
      {
         if (oldDrug == null)
            return;
         if (this.drug != null)
            if (this.drug.Contains(oldDrug))
               this.drug.Remove(oldDrug);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDrug()
      {
         if (drug != null)
            drug.Clear();
      }
   
      private DateTime StartDate;
      private DateTime EndDate;
      private String CauseForHospTreatment;
   
   }
=======
        private List<Drug> drugs;

        /// <pdGenerated>default getter</pdGenerated>
       
   
      private DateTime startDate;
      private DateTime endDate;
      private String causeForHospTreatment;

        public ReferralToHospitalTreatment(DateTime startDate, DateTime endDate, string causeForHospTreatment)
        {
            StartDate = startDate;
            EndDate = endDate;
            CauseForHospTreatment = causeForHospTreatment;
        }

        public ReferralToHospitalTreatment(DateTime startDate, DateTime endDate, string causeForHospTreatment, List<Drug> drugs)
        {
            Drugs = drugs;
            StartDate = startDate;
            EndDate = endDate;
            CauseForHospTreatment = causeForHospTreatment;
        }

        public List<Drug> Drugs { get => drugs; set => drugs = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string CauseForHospTreatment { get => causeForHospTreatment; set => causeForHospTreatment = value; }
    }
>>>>>>> master
}