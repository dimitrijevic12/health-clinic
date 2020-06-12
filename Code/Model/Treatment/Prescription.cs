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

<<<<<<< HEAD
        public int Id { get => id; set => id = value; }
=======
        public Prescription(List<Drug> drug)
        {
            Id = id;
            this.Drug = drug;
        }

        public Prescription()
        {
        }

        public long Id { get => id; set => id = value; }
        public List<Drug> Drug { get => drug; set => drug = value; }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

        public override string ToString()
        {
            string outString = "";
            outString = Id + " " ;
            foreach(Drug oneDrug in Drug)
            {
                outString += oneDrug.Name + " " + oneDrug.Quantity;
            }
            return outString;
        }
>>>>>>> master
    }
}