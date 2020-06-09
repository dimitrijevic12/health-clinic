/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.MedicalRecord
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections;

namespace Model.Appointment
{
   public class MedicalRecord
   {
        public long id;
        public System.Collections.ArrayList treatments;
        public Doctor choosenDoctor;
        public Model.SystemUsers.Patient patient;

        /// <pdGenerated>default getter</pdGenerated>

        public MedicalRecord(long id, Patient patient, Doctor doctor)
<<<<<<< HEAD
      {
            this.id = id;
            this.patient = patient;
            this.choosenDoctor = doctor;
      }
=======
        {
            this.id = id;
            this.patient = patient;
            this.choosenDoctor = doctor;
        }
>>>>>>> master

        public MedicalRecord(Patient patient, ArrayList treatments, Doctor doctor)
        {
            this.id = id;
            this.patient = patient;
            this.treatments = treatments;
            this.choosenDoctor = doctor;
        }

        public System.Collections.ArrayList GetTreatment()
        {
            if (treatments == null)
<<<<<<< HEAD
            treatments = new System.Collections.ArrayList();
            return treatments;
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
         if (this.treatments == null)
            this.treatments = new System.Collections.ArrayList();
         if (!this.treatments.Contains(newTreatment))
            this.treatments.Add(newTreatment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTreatment(Model.Treatment.Treatment oldTreatment)
      {
         if (oldTreatment == null)
            return;
         if (this.treatments != null)
            if (this.treatments.Contains(oldTreatment))
               this.treatments.Remove(oldTreatment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTreatment()
      {
         if (treatments != null)
            treatments.Clear();
      }
      
   
   }
=======
                treatments = new System.Collections.ArrayList();
            return treatments;
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
            if (this.treatments == null)
                this.treatments = new System.Collections.ArrayList();
            if (!this.treatments.Contains(newTreatment))
                this.treatments.Add(newTreatment);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveTreatment(Model.Treatment.Treatment oldTreatment)
        {
            if (oldTreatment == null)
                return;
            if (this.treatments != null)
                if (this.treatments.Contains(oldTreatment))
                    this.treatments.Remove(oldTreatment);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllTreatment()
        {
            if (treatments != null)
                treatments.Clear();
        }

    }
>>>>>>> master
}