/***********************************************************************
 * Module:  TreatmentCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.TreatmentCSVConverter
 ***********************************************************************/

using Model.Rooms;
using Model.Treatment;
using System;

namespace Repository.Csv.Converter
{
   public class TreatmentCSVConverter : ICSVConverter<Treatment>
   {
      private String Delimiter;

        public Treatment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            long id = long.Parse(tokens[0]);
//            Doctor doctor = new Doctor();
            DateTime fromDate = DateTime.Parse(tokens[2]);
            DateTime toDate = DateTime.Parse(tokens[3]);


            return null;
        }

        public string ConvertEntityToCSVFormat(Treatment entity)
        {
            string doctor = entity.Doctor.ToString();
            string fromDate = entity.FromDate.ToString("dd-MM-yyyy");
            string toDate = entity.EndDate.ToString("dd-MM-yyyy");
            string id = entity.Id.ToString();
            string prescription = "";
            foreach (Drug drug in entity.Prescription.Drug)
            {
                prescription += drug.Name + ",";
            }
            string scheduledSurgery = entity.ScheduledSurgery.StartDate + "," + entity.ScheduledSurgery.EndDate + "," + entity.ScheduledSurgery.CauseForOperation + "," + entity.ScheduledSurgery.Surgeon;
            string diagnosisAndReview = entity.DiagnosisAndReview.Diagnosis + entity.DiagnosisAndReview.Review;
            string referralToAHospitalTreatment = entity.ReferralToHospitalTreatment.StartDate.ToString() + entity.ReferralToHospitalTreatment.EndDate.ToString() + entity.ReferralToHospitalTreatment.CauseForHospTreatment;

            return string.Join(Delimiter, id, doctor, fromDate, toDate, prescription, scheduledSurgery, diagnosisAndReview, referralToAHospitalTreatment);
        }
    }
}