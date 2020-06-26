/***********************************************************************
 * Module:  IMedicalRecordRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IMedicalRecordRepository
 ***********************************************************************/

using Model.Appointment;
using Model.Treatment;
using System;

namespace Repository
{
   public interface IMedicalRecordRepository : IRepository<MedicalRecord>
   {
      Model.Appointment.MedicalRecord GetMedRecByPatient(Model.SystemUsers.Patient patient);
      Model.Appointment.MedicalRecord GetMedRecByTreatmentId(long id);
      Model.Appointment.MedicalRecord AddTreatmentToMedRec(Model.SystemUsers.Patient patient, Model.Treatment.Treatment treatment);
      Model.Appointment.MedicalRecord EditTreatmentInMedRec(Model.Treatment.Treatment treatment, Model.Appointment.MedicalRecord medRec);
        Treatment GetTreatmentByTreatmentId(long id);
        MedicalRecord getMedRecById(long id);
   }
}