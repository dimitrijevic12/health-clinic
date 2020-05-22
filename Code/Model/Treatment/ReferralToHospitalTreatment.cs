/***********************************************************************
 * Module:  ReferralToHospitalTreatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.ReferralToHospitalTreatment
 ***********************************************************************/

using System;

namespace Model.Treatment
{
   public class ReferralToHospitalTreatment
   {
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
}