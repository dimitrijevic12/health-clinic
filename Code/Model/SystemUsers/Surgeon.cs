/***********************************************************************
 * Module:  Surgeon.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Surgeon
 ***********************************************************************/

using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using System;

namespace Model.SystemUsers
{
    public class Surgeon : Doctor
    {
        private SurgicalSpecialty surgicalSpecialty;

        public Surgeon(long id, String name, String surname, Gender gender, DateTime dateOfBirth, SurgicalSpecialty surgicalSpecialty) : base(id, name, surname, gender, dateOfBirth)
        {
            SurgicalSpecialty = surgicalSpecialty;
        }

<<<<<<< HEAD
        public Surgeon(String name, String surname, SurgicalSpecialty surgicalSpecialty) : base( name, surname)
        {
=======
        public Surgeon(String name, String surname, SurgicalSpecialty surgicalSpecialty)
        {
            Name = name;
            Surname = surname;
>>>>>>> master
            SurgicalSpecialty = surgicalSpecialty;
        }

        public SurgicalSpecialty SurgicalSpecialty { get => surgicalSpecialty; set => surgicalSpecialty = value; }
    }
}