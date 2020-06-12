/***********************************************************************
 * Module:  Surgeon.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Surgeon
 ***********************************************************************/

using System;

namespace Model.SystemUsers
{
    public class Surgeon : Doctor
    {
        private SurgicalSpecialty SurgicalSpecialty;

        public Surgeon(String name, String surname, SurgicalSpecialty surgicalSpecialty) : base(name, surname)
        {
            SurgicalSpecialty = surgicalSpecialty;
        }
    }
}