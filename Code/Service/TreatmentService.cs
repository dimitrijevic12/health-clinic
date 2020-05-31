/***********************************************************************
 * Module:  TreatmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.TreatmentService
 ***********************************************************************/

using Controller;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Service
{
   public class TreatmentService : ITreatmentService
   {
      public TreatmentService GetInstance() { return null; }

        public Prescription WritePrescription(Drug[] drugs, Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public ReferralToASpecialist WriteReferralToASpecialist(Doctor specialist, Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public ScheduledSurgery ScheduleSurgery(Treatment treatment, DateTime fromDate, DateTime toDate, string cause)
        {
            throw new NotImplementedException();
        }

        public DiagnosisAndReview WriteDiagnosisAndReview(Treatment treatment, string diagnosis, string review)
        {
            throw new NotImplementedException();
        }

        public ReferralToHospitalTreatment WriteReferralToHospTreat(Treatment treatment, DateTime startDate, DateTime endDate, string cause, Drug[] drugs)
        {
            throw new NotImplementedException();
        }

        public Appointment ScheduleControlAppointment(Appointment appointment, int fromDate, int toDate)
        {
            throw new NotImplementedException();
        }

        public Treatment Create(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment Edit(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public List<Treatment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Repository.ITreatmentRepository iTreatmentRepository;
   
      private static TreatmentService Instance;
   
   }
}