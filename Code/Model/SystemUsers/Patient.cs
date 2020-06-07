/***********************************************************************
 * Module:  Patient.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Patient
 ***********************************************************************/

using System;

namespace Model.SystemUsers
{
   public class Patient : RegisteredUser
   {
      private DateTime dateOfBirth;
      private Boolean guestAccount;
      private Gender gender;
        

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