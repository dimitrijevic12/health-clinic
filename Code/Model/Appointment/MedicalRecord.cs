/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.MedicalRecord
 ***********************************************************************/

using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using System;
using System.Collections;
using System.ComponentModel;

namespace Model.Appointment
{
<<<<<<< HEAD
    public class MedicalRecord : INotifyPropertyChanged
    {

=======
   public class MedicalRecord : INotifyPropertyChanged
    {
>>>>>>> master
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public long id;
        public System.Collections.ArrayList treatments;
        public Doctor choosenDoctor;
        public Model.SystemUsers.Patient patient;

        /// <pdGenerated>default getter</pdGenerated>
        /// 
        public long IDnaloga
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    OnPropertyChanged("IDNaloga");
                }
            }
        }

        public string Name
        {
            get
            {
                return patient.Name;
            }
            set
            {
                if (!value.Equals(patient.Name))
                {
                    patient.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Surname
        {
            get
            {
                return patient.Surname;
            }
            set
            {
                if (!value.Equals(patient.Surname))
                {
                    patient.Surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }

        public long IDPatient
        {
            get
            {
                return patient.Id;
            }
            set
            {
                if (value != patient.Id)
                {
                    patient.Id = value;
                    OnPropertyChanged("IDPatient");
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return patient.DateOfBirth;
            }
            set
            {
                if (!value.Equals(patient.DateOfBirth))
                {
                    patient.DateOfBirth = value;
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }

        public Gender GenderProp
        {
            get
            {
                return patient.Gender;
            }
            set
            {
                if (!value.Equals(patient.Gender))
                {
                    patient.Gender = value;
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }

        public String Doctor
        {
            get
            {
                return choosenDoctor.Name + " " + choosenDoctor.Surname;
            }
            set
            {
                if (!value.Equals(patient.Name + " " + choosenDoctor.Surname))
                {
<<<<<<< HEAD
                    patient.Name= value;
=======
                    patient.Name = value;
>>>>>>> master
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }



        public MedicalRecord(long id, Patient patient, Doctor doctor)
        {
            this.id = id;
            this.patient = patient;
            this.choosenDoctor = doctor;
        }

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
}