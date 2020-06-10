/***********************************************************************
 * Module:  ReferralToHospitalTreatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.ReferralToHospitalTreatment
 ***********************************************************************/

using System;
using System.Collections;

namespace Model.Treatment
{
   public class ReferralToHospitalTreatment
   {
        private System.Collections.ArrayList drug;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetDrug()
      {
         if (Drug == null)
            Drug = new System.Collections.ArrayList();
         return Drug;
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
         if (this.Drug == null)
            this.Drug = new System.Collections.ArrayList();
         if (!this.Drug.Contains(newDrug))
            this.Drug.Add(newDrug);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDrug(Model.Rooms.Drug oldDrug)
      {
         if (oldDrug == null)
            return;
         if (this.Drug != null)
            if (this.Drug.Contains(oldDrug))
               this.Drug.Remove(oldDrug);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDrug()
      {
         if (Drug != null)
            Drug.Clear();
      }
   
      private DateTime startDate;
      private DateTime endDate;
      private String causeForHospTreatment;

        public ArrayList Drug { get => drug; set => drug = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string CauseForHospTreatment { get => causeForHospTreatment; set => causeForHospTreatment = value; }
    }
}