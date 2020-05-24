/***********************************************************************
 * Module:  TreatmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.TreatmentService
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using System;

namespace Controller
{
   public class TreatmentController : ITreatmentController
   {
      public Service.TreatmentService treatmentService;

        public Treatment Create(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment Edit(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Diagnosis WriteDiagnosis(Treatment treatment, Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public Prescription WritePrescription(Doctor doctor, Patient patient, Drug[] drugs)
        {
            throw new NotImplementedException();
        }

        public ReferralToASpecialist WriteReferralToASpecialist(Doctor doctor, Patient patient, Specialist specialist)
        {
            throw new NotImplementedException();
        }

        public ReferralToHospitalTreatment WriteReferralToHospTreat(Treatment treatment, int startDate, int endDate, string cause, RehabilitationRoom room)
        {
            throw new NotImplementedException();
        }

        public ReferralToOperation WriteReferralToOperation(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public Review WriteReview(Treatment treatment, Review review)
        {
            throw new NotImplementedException();
        }
    }
}