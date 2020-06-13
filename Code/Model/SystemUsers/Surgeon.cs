/***********************************************************************
 * Module:  Surgeon.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Surgeon
 ***********************************************************************/

using health_clinicClassDiagram.Model.SystemUsers;
using System;

namespace Model.SystemUsers
{
   public class Surgeon : Doctor
   {
      private SurgicalSpecialty surgicalSpecialty;
        
        public Surgeon(long id, String name, String surname, Gender gender, /*DateTime*/string dateOfBirth, SurgicalSpecialty surgicalSpecialty) : base(id, name, surname, gender, dateOfBirth)
        {
            SurgicalSpecialty = surgicalSpecialty;
        }

        public Surgeon(String name, String surname, SurgicalSpecialty surgicalSpecialty)
        {
            SurgicalSpecialty = surgicalSpecialty;
        }

        public SurgicalSpecialty SurgicalSpecialty { get => surgicalSpecialty; set => surgicalSpecialty = value; }
    }
}