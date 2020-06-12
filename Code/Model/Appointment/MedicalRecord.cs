/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.MedicalRecord
 ***********************************************************************/

using Model.SystemUsers;
<<<<<<< HEAD
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
=======
using Model.Treatment;
>>>>>>> master
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model.Appointment
{

    public class MedicalRecord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public long id;
        private List<Model.Treatment.Treatment> treatments;
        public Doctor choosenDoctor;
        private Patient patient;

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
                return Patient.Name;
            }
            set
            {
                if (!value.Equals(Patient.Name))
                {
                    Patient.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Surname
        {
            get
            {
                return Patient.Surname;
            }
            set
            {
                if (!value.Equals(Patient.Surname))
                {
                    Patient.Surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }

        public long IDPatient
        {
            get
            {
                return Patient.Id;
            }
            set
            {
                if (value != Patient.Id)
                {
                    Patient.Id = value;
                    OnPropertyChanged("IDPatient");
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return Patient.DateOfBirth;
            }
            set
            {
                if (!value.Equals(Patient.DateOfBirth))
                {
                    Patient.DateOfBirth = value;
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }

        public Gender GenderProp
        {
            get
            {
                return Patient.Gender;
            }
            set
            {
                if (!value.Equals(Patient.Gender))
                {
                    Patient.Gender = value;
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
                if (!value.Equals(Patient.Name + " " + choosenDoctor.Surname))
                {
                    Patient.Name = value;
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }

        public List<Model.Treatment.Treatment> Treatments { get => treatments; set => treatments = value; }
        public Patient Patient { get => patient; set => patient = value; }

        public MedicalRecord(long id, Patient patient, Doctor doctor, List<Model.Treatment.Treatment> treatments)
        {
            this.id = id;
            this.Patient = patient;
            this.choosenDoctor = doctor;
            Treatments = treatments;
        }

        public MedicalRecord(Patient patient, List<Model.Treatment.Treatment> treatments, Doctor doctor)
        {
            this.id = id;
            this.Patient = patient;
            this.Treatments = treatments;
            this.choosenDoctor = doctor;
        }

<<<<<<< HEAD
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
=======
>>>>>>> master
    }
}