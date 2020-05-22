/***********************************************************************
 * Module:  Treatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Treatment
 ***********************************************************************/

using System;

namespace Model.Treatment
{
   public class Treatment
   {
      public System.Collections.ArrayList prescription;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPrescription()
      {
         if (prescription == null)
            prescription = new System.Collections.ArrayList();
         return prescription;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPrescription(System.Collections.ArrayList newPrescription)
      {
         RemoveAllPrescription();
         foreach (Prescription oPrescription in newPrescription)
            AddPrescription(oPrescription);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPrescription(Prescription newPrescription)
      {
         if (newPrescription == null)
            return;
         if (this.prescription == null)
            this.prescription = new System.Collections.ArrayList();
         if (!this.prescription.Contains(newPrescription))
            this.prescription.Add(newPrescription);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePrescription(Prescription oldPrescription)
      {
         if (oldPrescription == null)
            return;
         if (this.prescription != null)
            if (this.prescription.Contains(oldPrescription))
               this.prescription.Remove(oldPrescription);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPrescription()
      {
         if (prescription != null)
            prescription.Clear();
      }
      public ReferralToASpecialist referralToASpecialist;
      public ReferralToOperation referralToOperation;
      public Review review;
      public Diagnosis diagnosis;
      public ReferralToHospitalTreatment referralToHospitalTreatment;
   
      private DateTime FromDate;
      private DateTime EndDate;
   
   }
}