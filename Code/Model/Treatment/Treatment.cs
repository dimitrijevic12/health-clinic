/***********************************************************************
 * Module:  Treatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Treatment
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Model.Treatment
{
   public class Treatment
   {
        /// <pdGenerated>default getter</pdGenerated>

        private Prescription prescription;
        private ScheduledSurgery scheduledSurgery;
        private DiagnosisAndReview diagnosisAndReview;
        private ReferralToHospitalTreatment referralToHospitalTreatment;
        private Model.SystemUsers.Doctor doctor;

        private DateTime fromDate;
      private DateTime endDate;
      private long id;

        public Prescription Prescription { get => prescription; set => prescription = value; }
        public ScheduledSurgery ScheduledSurgery { get => scheduledSurgery; set => scheduledSurgery = value; }
        public DiagnosisAndReview DiagnosisAndReview { get => diagnosisAndReview; set => diagnosisAndReview = value; }
        public ReferralToHospitalTreatment ReferralToHospitalTreatment { get => referralToHospitalTreatment; set => referralToHospitalTreatment = value; }
        public DateTime FromDate { get => fromDate; set => fromDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public long Id { get => id; set => id = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
    }
}