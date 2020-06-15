/***********************************************************************
 * Module:  TreatmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.TreatmentCSVConverter
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Repository.Csv.Converter
{
    public class TreatmentCSVConverter : ICSVConverter<Treatment>
    {
        private String Delimiter;

        public TreatmentCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public Treatment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            long id = long.Parse(tokens[0]);

            string doctorName = tokens[1];
            string doctorSurname = tokens[2];
            Doctor doctor = new Doctor(doctorName, doctorSurname);

            DateTime fromDate = DateTime.Parse(tokens[3]);
            DateTime toDate = DateTime.Parse(tokens[4]);
            toDate = toDate.AddHours(2);

            List<Drug> drugs = new List<Drug>();
            string drugString = tokens[5];
            string[] drugParts = drugString.Split(',');
            foreach (string oneDrug in drugParts)
            {
                if (oneDrug == "") break;
                Drug drug = new Drug(oneDrug);
                drugs.Add(drug);
            }
            Prescription prescription = new Prescription(drugs);

            string scheduledSurgeryString = tokens[6];
            string[] scheduledSurgeryParts = scheduledSurgeryString.Split(',');
            DateTime ssFromDate = DateTime.Parse(scheduledSurgeryParts[0]);
            DateTime ssToDate = DateTime.Parse(scheduledSurgeryParts[1]);
            string ssCause = scheduledSurgeryParts[2];
            string surgeonName = scheduledSurgeryParts[3];
            string surgeonSurname = scheduledSurgeryParts[4];
            SurgicalSpecialty surgeonSpecialty; //Enum.Parse(SurgicalSpecialty, scheduledSurgeryParts[5]);
            Enum.TryParse("Active", out surgeonSpecialty);
            ScheduledSurgery scheduledSurgery = new ScheduledSurgery(ssFromDate, ssToDate, ssCause, new Surgeon(surgeonName, surgeonSurname, surgeonSpecialty));

            string diagnosisAndReviewString = tokens[7];
            string[] diagnosisAndReviewParts = diagnosisAndReviewString.Split(',');
            string diagnosis = diagnosisAndReviewParts[0];
            string review = diagnosisAndReviewParts[1];
            DiagnosisAndReview diagnosisAndReview = new DiagnosisAndReview(diagnosis, review);

            string hospitalTreatmentString = tokens[8];
            string[] hospitalTreatmentParts = hospitalTreatmentString.Split(',');
            DateTime hospitalTreatmentFromDate = DateTime.Parse(hospitalTreatmentParts[0]);
            DateTime hospitalTreatmentToDate = DateTime.Parse(hospitalTreatmentParts[1]);
            string hospitalTreatmentCause = hospitalTreatmentParts[2];
            ReferralToHospitalTreatment hospitalTreatment = new ReferralToHospitalTreatment(hospitalTreatmentFromDate, hospitalTreatmentToDate, hospitalTreatmentCause);

            return new Treatment(prescription, scheduledSurgery, diagnosisAndReview, hospitalTreatment, fromDate, toDate, id, doctor);
        }

        public string ConvertEntityToCSVFormat(Treatment entity)
        {
            string doctorName = entity.Doctor.Name;
            string doctorSurname = entity.Doctor.SurnameDoctor;
            string fromDate = entity.FromDate.ToString("dd-MM-yyyy");
            string toDate = entity.EndDate.ToString("dd-MM-yyyy");
            string id = entity.Id.ToString();
            string prescription = "";
            foreach (Drug drug in entity.Prescription.Drug)
            {
                prescription += drug.Name + ",";
            }
            string scheduledSurgery = entity.ScheduledSurgery.StartDate + "," + entity.ScheduledSurgery.EndDate + "," + entity.ScheduledSurgery.CauseForOperation + "," + entity.ScheduledSurgery.Surgeon.NameDoctor + ',' + entity.ScheduledSurgery.Surgeon.SurnameDoctor + ',' + entity.ScheduledSurgery.Surgeon.Spec;
            string diagnosisAndReview = entity.DiagnosisAndReview.Diagnosis + "," + entity.DiagnosisAndReview.Review;
            string referralToAHospitalTreatment = entity.ReferralToHospitalTreatment.StartDate.ToString() + "," + entity.ReferralToHospitalTreatment.EndDate.ToString() + "," + entity.ReferralToHospitalTreatment.CauseForHospTreatment;

            return string.Join(Delimiter, id, doctorName, doctorSurname, fromDate, toDate, prescription, scheduledSurgery, diagnosisAndReview, referralToAHospitalTreatment);
        }
    }
}