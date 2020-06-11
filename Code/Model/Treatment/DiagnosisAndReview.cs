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
        private int id;
      private String diagnosis;
      private String review;

        public string Diagnosis { get => diagnosis; set => diagnosis = value; }
        public string Review { get => review; set => review = value; }
        public int Id { get => id; set => id = value; }

        public DiagnosisAndReview(string diagnosis, string review, int id)
        {
            Diagnosis = diagnosis;
            Review = review;
            Id = id;
        }

        public DiagnosisAndReview()
        {
            Id = 0;
            Diagnosis = "Neka dijagnoza";
            Review = "Neka procedura";
        }
    }
}