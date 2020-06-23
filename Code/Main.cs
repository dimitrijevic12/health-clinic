using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Rooms;
using Model.Treatment;
using Repository;
using Model.SystemUsers;
using Model.Surveys;
using Controller;

namespace health_clinicClassDiagram
{
    public static class MainClass
    {
        static void Main()
         {/*
                         DiagnosisAndReview diagnosisAndReview = new DiagnosisAndReview("Nova dijagnoza", "Nova procedura");
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

             DiagnosisAndReview diagnosisAndReview = new DiagnosisAndReview("Nova dijagnoza", "Nova procedura");
             Drug drug1 = new Drug(null, "Panklav 200mg", "Opis Panklava", true, 20);
             Drug drug2 = new Drug(null, "Aerius 50mg", "Opis Aeriusa", false, 5);
             List<Drug> drugs = new List<Drug>();
             drugs.Add(drug1);
             drugs.Add(drug2);
             Prescription prescription = new Prescription(drugs);
             Treatment treatment = new Treatment(prescription, new ScheduledSurgery(DateTime.Today, DateTime.Now, "Razlog operacije", new Surgeon("Pera", "Peric", SurgicalSpecialty.CARDIOTHORACIC)), diagnosisAndReview, new ReferralToHospitalTreatment(DateTime.Today, DateTime.Now, "Razlog bolnickog lecenja"), DateTime.Today, DateTime.Now, new Doctor("Marko", "Markovic"));
             TreatmentRepository.Instance.Save(treatment);
         */
            Blog blog1 = new Blog("naslov 1", "blablbalblalba", DateTime.Now);
            Blog blog2 = new Blog("naslov 2", "blablbalblalba", DateTime.Now.AddHours(2));
            BlogController.Instance.Create(blog1);
            BlogController.Instance.Create(blog2);
            BlogController.Instance.GetBlogByTitle("naslov 1");
            BlogController.Instance.Delete(blog1);
            blog2.Text = "Promenjen text";
            BlogController.Instance.Edit(blog2);
        }
        

    }
}
