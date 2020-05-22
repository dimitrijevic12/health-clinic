/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.MedicalRecord
 ***********************************************************************/

using System;

namespace Model.Appointment
{
   public class MedicalRecord
   {
      public System.Collections.ArrayList treatment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetTreatment()
      {
         if (treatment == null)
            treatment = new System.Collections.ArrayList();
         return treatment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetTreatment(System.Collections.ArrayList newTreatment)
      {
         RemoveAllTreatment();
         foreach (Model.Treatment.Treatment oTreatment in newTreatment)
            AddTreatment(oTreatment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddTreatment(Model.Treatment.Treatment newTreatment)
      {
         if (newTreatment == null)
            return;
         if (this.treatment == null)
            this.treatment = new System.Collections.ArrayList();
         if (!this.treatment.Contains(newTreatment))
            this.treatment.Add(newTreatment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTreatment(Model.Treatment.Treatment oldTreatment)
      {
         if (oldTreatment == null)
            return;
         if (this.treatment != null)
            if (this.treatment.Contains(oldTreatment))
               this.treatment.Remove(oldTreatment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTreatment()
      {
         if (treatment != null)
            treatment.Clear();
      }
      public Model.SystemUsers.Patient patient;
   
   }
}