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
      Model.Treatment.Prescription WritePrescription(Model.Rooms.Drug[] drugs, Model.Treatment.Treatment treatment);
      ReferralToASpecialist WriteReferralToASpecialist(Model.SystemUsers.Doctor specialist, Model.Treatment.Treatment treatment);
      Model.Treatment.ScheduledSurgery ScheduleOperation(Model.Treatment.Treatment treatment, DateTime fromDate, DateTime toDate, String cause);
      Model.Treatment.DiagnosisAndReview WriteDiagnosisAndReview(Model.Treatment.Treatment treatment, Model.Treatment.DiagnosisAndReview diagnosis);
      Model.Treatment.ReferralToHospitalTreatment WriteReferralToHospTreat(Model.Treatment.Treatment treatment, DateTime startDate, DateTime endDate, String cause, Model.Rooms.Drug[] drugs);
      Model.Appointment.Appointment ScheduleControlAppointment(Model.Appointment.Appointment appointment, int fromDate, int toDate);
   }
}