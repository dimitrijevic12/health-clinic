/***********************************************************************
 * Module:  ITreatmentController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.ITreatmentController
 ***********************************************************************/

using Model.Treatment;
using System;

namespace Controller
{
   public interface ITreatmentController : IController<Treatment>
   {
      Model.Treatment.Prescription WritePrescription(Model.SystemUsers.Doctor doctor, Model.SystemUsers.Patient patient, Model.Rooms.Drug[] drugs);
      Model.Treatment.ReferralToASpecialist WriteReferralToASpecialist(Model.SystemUsers.Doctor doctor, Model.SystemUsers.Patient patient, Model.SystemUsers.Specialist specialist);
      Model.Treatment.ReferralToOperation WriteReferralToOperation(Model.Treatment.Treatment treatment);
      Model.Treatment.Diagnosis WriteDiagnosis(Model.Treatment.Treatment treatment, Model.Treatment.Diagnosis diagnosis);
      Model.Treatment.Review WriteReview(Model.Treatment.Treatment treatment, Model.Treatment.Review review);
      Model.Treatment.ReferralToHospitalTreatment WriteReferralToHospTreat(Model.Treatment.Treatment treatment, int startDate, int endDate, String cause, Model.Rooms.RehabilitationRoom room);
   }
}