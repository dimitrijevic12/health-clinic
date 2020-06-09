using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Treatment;
using Repository;

namespace health_clinicClassDiagram
{
    public static class MainClass
    {
        static void Main()
        {
            DiagnosisAndReview diagnosisAndReview = new DiagnosisAndReview("Nova dijagnoza", "Nova procedura", 4);
            DiagnosisAndReviewRepository.Instance.Save(diagnosisAndReview);
            DiagnosisAndReviewRepository.Instance.Delete(2);
            List<DiagnosisAndReview> diagnosisAndReviews =  DiagnosisAndReviewRepository.Instance.GetAll();
            Console.WriteLine("Lista dijagnoza:");
            foreach (DiagnosisAndReview dAndR in diagnosisAndReviews)
            {
                Console.WriteLine(dAndR.Id);
            }
            Console.WriteLine("Dijagnoza id == 3:" + DiagnosisAndReviewRepository.Instance.GetDiagnosisAndReview(3).Id);
        }
    }
}
