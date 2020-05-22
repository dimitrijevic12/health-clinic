/***********************************************************************
 * Module:  Diagnosis.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Diagnosis
 ***********************************************************************/

using System;

namespace Model.Treatment
{
   public class Diagnosis
   {
      public System.Collections.ArrayList symptoms;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSymptoms()
      {
         if (symptoms == null)
            symptoms = new System.Collections.ArrayList();
         return symptoms;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSymptoms(System.Collections.ArrayList newSymptoms)
      {
         RemoveAllSymptoms();
         foreach (Symptoms oSymptoms in newSymptoms)
            AddSymptoms(oSymptoms);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSymptoms(Symptoms newSymptoms)
      {
         if (newSymptoms == null)
            return;
         if (this.symptoms == null)
            this.symptoms = new System.Collections.ArrayList();
         if (!this.symptoms.Contains(newSymptoms))
            this.symptoms.Add(newSymptoms);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSymptoms(Symptoms oldSymptoms)
      {
         if (oldSymptoms == null)
            return;
         if (this.symptoms != null)
            if (this.symptoms.Contains(oldSymptoms))
               this.symptoms.Remove(oldSymptoms);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSymptoms()
      {
         if (symptoms != null)
            symptoms.Clear();
      }
   
      private String Diagnosis;
   
   }
}