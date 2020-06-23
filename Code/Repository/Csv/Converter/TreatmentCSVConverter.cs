/***********************************************************************
 * Module:  TreatmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.TreatmentCSVConverter
 ***********************************************************************/

using health_clinicClassDiagram.Repository;
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

            string doctorId = tokens[1];
            Doctor doctor = DoctorRepository.Instance.GetDoctorById(long.Parse(doctorId));

            DateTime startDate = DateTime.Parse(tokens[3]);
            DateTime endDate = DateTime.Parse(tokens[4]);

            List<Drug> prescriptionDrugs = new List<Drug>();
            string prescriptionDrugString = tokens[5];
            string[] prescriptionDrugParts = prescriptionDrugString.Split('|');
            foreach(long oneDrug in prescriptionDrugParts)
            {
                Drug drug = new Drug(oneDrug);
                prescriptionDrugs.Add(drug);
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

            return new Treatment(prescription, scheduledSurgery, diagnosisAndReview, hospitalTreatment, fromDate, toDate, doctor);
        }

        public string ConvertEntityToCSVFormat(Treatment entity)
        {
            string id = entity.Id.ToString();
            string doctorId = entity.Doctor.Id.ToString();           
            string startDate = entity.FromDate.ToString("dd-MM-yyyy");
            string endDate = entity.EndDate.ToString("dd-MM-yyyy");
            string prescription = "";
            foreach (Drug drug in entity.Prescription.Drug)
            {
                if(entity.Prescription.Drug.IndexOf(drug) == entity.Prescription.Drug.Count - 1)
                {
                    prescription += drug.Id;
                }
                else
                {
                    prescription += drug.Id + "|";
                }
            }
            string scheduledSurgery = entity.ScheduledSurgery.StartDate + "," + entity.ScheduledSurgery.EndDate + "," + entity.ScheduledSurgery.CauseForOperation + "," + entity.ScheduledSurgery.Surgeon.Id;
            string specialistAppointment = entity.SpecialistAppointment.Doctor.Id + "," + entity.SpecialistAppointment.Cause;
            string referralToAHospitalTreatment = entity.ReferralToHospitalTreatment.StartDate.ToString() + "," + entity.ReferralToHospitalTreatment.EndDate.ToString() + "," + entity.ReferralToHospitalTreatment.CauseForHospTreatment + ",";
            string hospitalTreatmentDrugs = "";
            foreach (Drug drug in entity.ReferralToHospitalTreatment.Drugs)
            {
                if (entity.ReferralToHospitalTreatment.Drugs.IndexOf(drug) == entity.ReferralToHospitalTreatment.Drugs.Count - 1)
                {
                    hospitalTreatmentDrugs += drug.Id;
                }
                else
                {
                    hospitalTreatmentDrugs += drug.Id + "|";
                }
            }
            referralToAHospitalTreatment += hospitalTreatmentDrugs;
            string diagnosisAndReview = entity.DiagnosisAndReview.Diagnosis + "," + entity.DiagnosisAndReview.Review;
            return string.Join(Delimiter, id, doctorId, startDate, endDate, prescription, scheduledSurgery, specialistAppointment, referralToAHospitalTreatment, diagnosisAndReview);
        }
    }
}