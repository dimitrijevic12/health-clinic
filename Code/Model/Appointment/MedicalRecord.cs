/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.MedicalRecord
 ***********************************************************************/

using Model.SystemUsers;

using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using Model.Treatment;
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
        private DateTime rehabilitationFrom;
        private DateTime rehabilitationTo;

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

        public DateTime RehabilitationFrom
        {
            get { return rehabilitationFrom; }   // get method
            set { rehabilitationFrom = value; }
        }

        public DateTime RehabilitationTo
        {
            get { return rehabilitationTo; }   // get method
            set { rehabilitationTo = value; }
        }

        public String DateOfBirthTekst { get => DateOfBirth.ToShortDateString(); }

        public String IdNameSurnameDoctor
        {
            get
            {
                return (choosenDoctor.Id + " " + choosenDoctor.Name + " " + choosenDoctor.Surname);
            }
            
        }

        public DateTime RehabilitationFrom
        {
            get { return rehabilitationFrom; }   // get method
            set { rehabilitationFrom = value; }
        }

        public DateTime RehabilitationTo
        {
            get { return rehabilitationTo; }   // get method
            set { rehabilitationTo = value; }
        }

        public String DateOfBirthTekst { get => DateOfBirth.ToShortDateString(); }

        public String IdNameSurnameDoctor
        {
            get
            {
                return (choosenDoctor.Id + " " + choosenDoctor.Name + " " + choosenDoctor.Surname);
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
            this.Patient = patient;
            this.Treatments = treatments;
            this.choosenDoctor = doctor;
        }

        public MedicalRecord(long id, Patient patient, Doctor doctor, List<Model.Treatment.Treatment> treatments, DateTime rehabilitationFrom, DateTime rehabilitationTo)
        {
            this.id = id;
            this.Patient = patient;
            this.choosenDoctor = doctor;
            Treatments = treatments;
            this.rehabilitationFrom = rehabilitationFrom;
            this.rehabilitationTo = rehabilitationTo;
        }

    }
}