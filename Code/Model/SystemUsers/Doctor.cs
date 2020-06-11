/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Doctor
 ***********************************************************************/

using health_clinicClassDiagram.Model.SystemUsers;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Model.SystemUsers
{
   public class Doctor : RegisteredUser
   {
<<<<<<< HEAD
      private WorkingSchedule[] workingSchedule;
      private Gender gender;
      private DateTime dateOfBirth;
      private Specialization spec;
=======
        private WorkingSchedule[] workingSchedule;
        private Gender gender;
        private DateTime dateOfBirth;
        private Specialization spec;
>>>>>>> master

        public long IdDoctor
        {
            get { return Id; }   // get method
            set { Id = value; }
        }

        public String NameDoctor
        {
            get { return Name; }   // get method
            set { Name = value; }
        }

        public String SurnameDoctor
        {
            get { return Surname; }   // get method
            set { Surname = value; }
        }

        public Gender Gender
        {
            get { return gender; }   // get method
            set { gender = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }   // get method
            set { dateOfBirth = value; }
        }

        public Specialization Spec
        {
            get { return spec; }   // get method
            set { spec = value; }
        }

        public Doctor() { }
<<<<<<< HEAD
        public Doctor(long jmbg, String name, String surname, Gender gender, DateTime dateOfBirth, Specialization specijalista) 
=======
        public Doctor(long jmbg, String name, String surname, Gender gender, DateTime dateOfBirth, Specialization specijalista)
>>>>>>> master
        {

            this.Id = jmbg;
            this.Name = name;
<<<<<<< HEAD
            this.Surname = surname;            
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
           // workingSchedule = workSc;
            Spec = specijalista;
            
=======
            this.Surname = surname;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            // workingSchedule = workSc;
            Spec = specijalista;

>>>>>>> master
        }
        public Doctor(long jmbg, String name, String surname)
        {
            this.Id = jmbg;
            this.Name = name;
            this.Surname = surname;
<<<<<<< HEAD
            
        }

=======

        }

        public Doctor(String name, String surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
>>>>>>> master

    }
}