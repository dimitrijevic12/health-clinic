/***********************************************************************
 * Module:  Treatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Treatment
 ***********************************************************************/

using health_clinicClassDiagram.Model.Treatment;
using Model.Appointment;
using Model.SystemUsers;
using System;
using System.ComponentModel;

namespace Model.Treatment
{
    public class Treatment : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        /// <pdGenerated>default getter</pdGenerated>

        private Prescription prescription;
        private ScheduledSurgery scheduledSurgery;
        private DiagnosisAndReview diagnosisAndReview;
        private ReferralToHospitalTreatment referralToHospitalTreatment;
        private Model.SystemUsers.Doctor doctor;
        private SpecialistAppointment specialistAppointment;
        private MedicalRecord record;

        private DateTime fromDate;
        private DateTime endDate;
        private long id;

        public Treatment(Prescription prescription, ScheduledSurgery scheduledSurgery, DiagnosisAndReview diagnosisAndReview, ReferralToHospitalTreatment referralToHospitalTreatment, DateTime fromDate, DateTime endDate, long id, Doctor doctor)
        {
            Prescription = prescription;
            ScheduledSurgery = scheduledSurgery;
            DiagnosisAndReview = diagnosisAndReview;
            ReferralToHospitalTreatment = referralToHospitalTreatment;
            FromDate = fromDate;
            EndDate = endDate;
            Id = id;
            Doctor = doctor;
        }

        public Treatment(Prescription prescription, ScheduledSurgery scheduledSurgery, DiagnosisAndReview diagnosisAndReview, ReferralToHospitalTreatment referralToHospitalTreatment, DateTime fromDate, DateTime endDate, Doctor doctor)
        {
            Prescription = prescription;
            ScheduledSurgery = scheduledSurgery;
            DiagnosisAndReview = diagnosisAndReview;
            ReferralToHospitalTreatment = referralToHospitalTreatment;
            FromDate = fromDate;
            EndDate = endDate;
            Doctor = doctor;
        }

        public Treatment(DateTime fromDate, DateTime endDate)
        {
            FromDate = fromDate;
            EndDate = endDate;
        }

        public Treatment()
        {
        }

        public MedicalRecord Record { get => record; set => record = value; }
        public Prescription Prescription { get => prescription; set => prescription = value; }
        public ScheduledSurgery ScheduledSurgery { get => scheduledSurgery; set => scheduledSurgery = value; }
        public DiagnosisAndReview DiagnosisAndReview { get => diagnosisAndReview; set => diagnosisAndReview = value; }
        public ReferralToHospitalTreatment ReferralToHospitalTreatment { get => referralToHospitalTreatment; set => referralToHospitalTreatment = value; }
        public DateTime FromDate { get => fromDate; set => fromDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public long Id { get => id; set => id = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public SpecialistAppointment SpecialistAppointment { get => specialistAppointment; set => specialistAppointment = value; }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}