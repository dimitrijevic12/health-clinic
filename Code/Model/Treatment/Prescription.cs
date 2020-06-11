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
        private long id;
        private List<Drug> drug;
        public Prescription(long id, List<Drug> drug)
        {
            Id = id;
            this.Drug = drug;;
        }

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
    }
}