/***********************************************************************
 * Module:  Diagnosis.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Diagnosis
 ***********************************************************************/

using System;

namespace Model.Treatment
{
   public class DiagnosisAndReview
   {
        private long id;
        private String diagnosis;
        private String review;

        public string Diagnosis { get => diagnosis; set => diagnosis = value; }
        public string Review { get => review; set => review = value; }
        public long Id { get => id; set => id = value; }

        public DiagnosisAndReview(string diagnosis, string review)
        {
            Diagnosis = diagnosis;
            Review = review;
        }

        public DiagnosisAndReview(long id, string diagnosis, string review)
        {
            Id = id;
            Diagnosis = diagnosis;
            Review = review;
        }

        public DiagnosisAndReview()
        {
            Id = 0;
            Diagnosis = "Neka dijagnoza";
            Review = "Neka procedura";
        }

        public override string ToString()
        {
            string outString = "";
            outString = /*Id + " " +*/ Diagnosis + ",  " + Review;
            return outString;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}