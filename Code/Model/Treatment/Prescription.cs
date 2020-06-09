/***********************************************************************
 * Module:  Prescription.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Prescription
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model.Treatment
{
   public class Prescription
   {
        private int id;
        public List<Model.Rooms.Drug> drug;

        public int Id { get => id; set => id = value; }
    }
}