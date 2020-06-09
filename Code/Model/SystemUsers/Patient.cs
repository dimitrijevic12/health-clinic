/***********************************************************************
 * Module:  Patient.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Patient
 ***********************************************************************/

using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using System;

namespace Model.SystemUsers
{
    public class Patient : RegisteredUser
   {

        private DateTime dateOfBirth;
        private Boolean guestAccount;
        private Gender gender;

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

        public Patient(String name, String surname, int jmbg)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = jmbg;
        }

        public Patient(String name, String surname, int jmbg, DateTime dateOfBirth, Gender gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = jmbg;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

    }

}

