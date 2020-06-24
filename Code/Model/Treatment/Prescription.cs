/***********************************************************************
 * Module:  Prescription.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Prescription
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Model.Treatment
{
   public class Prescription
   {
        private List<Drug> drug;
        public Prescription(List<Drug> drug)
        {
            this.Drug = drug;
        }

        public Prescription()
        {
        }

        public List<Drug> Drug { get => drug; set => drug = value; }
    }
}