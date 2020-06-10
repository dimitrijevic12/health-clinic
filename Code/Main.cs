using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Rooms;
using Model.Treatment;
using Repository;

namespace health_clinicClassDiagram
{
    public static class MainClass
    {
        static void Main()
        {
            /*            DiagnosisAndReview diagnosisAndReview = new DiagnosisAndReview("Nova dijagnoza", "Nova procedura");
                        DiagnosisAndReview diagnosisAndReview2 = new DiagnosisAndReview("Nova dijagnoza2", "Nova procedura2");
                        DiagnosisAndReviewRepository.Instance.Save(diagnosisAndReview);
                        DiagnosisAndReviewRepository.Instance.Save(diagnosisAndReview2);
                        //            DiagnosisAndReviewRepository.Instance.Delete(2);
                        List<DiagnosisAndReview> diagnosisAndReviews =  DiagnosisAndReviewRepository.Instance.GetAll();
                        Console.WriteLine("Lista dijagnoza:");
                        foreach (DiagnosisAndReview dAndR in diagnosisAndReviews)
                        {
                            Console.WriteLine(dAndR);
                        }
            //            Console.WriteLine("Dijagnoza id == 3:" + DiagnosisAndReviewRepository.Instance.GetDiagnosisAndReview(3).Id);
            */
            Drug drug1 = new Drug(null, "Panklav 200mg", "Opis Panklava", true, 20);
            Drug drug2 = new Drug(null, "Aerius 50mg", "Opis Aeriusa", false, 5);
            List<Drug> drugs = new List<Drug>();
            drugs.Add(drug1);
            drugs.Add(drug2);

            Prescription prescription = new Prescription(drugs);
            PrescriptionRepository.Instance.Save(prescription);
            List<Prescription> prescriptions = PrescriptionRepository.Instance.GetAll();
            PrescriptionRepository.Instance.Delete(3);
            foreach (Prescription p in prescriptions)
            {
                Console.WriteLine(p);
            }
        }

    }
}
