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
<<<<<<< HEAD
        public Prescription(long id, List<Drug> drug)
        {
            Id = id;
            this.Drug = drug; ;
        }

=======
>>>>>>> master
        public Prescription(List<Drug> drug)
        {
            this.Drug = drug;
        }

        public Prescription()
        {
        }

        public List<Drug> Drug { get => drug; set => drug = value; }
<<<<<<< HEAD

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

        public override string ToString()
        {
            string outString = "";
            //outString = Id + " ";
            foreach (Drug oneDrug in Drug)
            {
                outString += oneDrug.Name + ", "/* + " " + oneDrug.Quantity*/;
            }
            return outString;
        }
=======
>>>>>>> master
    }
}