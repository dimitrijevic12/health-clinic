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
      private WorkingSchedule[] workingSchedule;
      private Gender gender;
      private DateTime dateOfBirth;
        private string Spec;

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
        public Doctor() { }
        public Doctor(int jmbg, String name, String surname, Gender gender, DateTime dateOfBirth, String specijalista) 
        {

            this.Id = jmbg;
            this.Name = name;
            this.Surname = surname;            
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
           // workingSchedule = workSc;
            Spec = specijalista;
            
        }
        public Doctor(int jmbg, String name, String surname)
        {
            this.Id = jmbg;
            this.Name = name;
            this.Surname = surname;
            
        }


    }
}