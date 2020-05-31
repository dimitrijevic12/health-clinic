/***********************************************************************
 * Module:  IMedicalRecordRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IMedicalRecordRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IMedicalRecordRepository : IRepository
   {
      Model.Appointment.MedicalRecord GetMedRecByPatient(Model.SystemUsers.Patient patient);
      Model.Appointment.MedicalRecord GetMedRecByTreatmentId();
      Model.Appointment.MedicalRecord AddTreatmentToMedRec(Model.SystemUsers.Patient patient, Model.Treatment.Treatment treatment);
      Model.Appointment.MedicalRecord EditTreatmentInMedRec(Model.Treatment.Treatment treatment, Model.Appointment.MedicalRecord medRec);
   }
}