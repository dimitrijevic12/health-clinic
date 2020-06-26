/***********************************************************************
 * Module:  IMedicalRecordService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IMedicalRecordService
 ***********************************************************************/

using Model.Appointment;
using System;
using System.Collections.Generic;

namespace Service
{
   public interface IMedicalRecordService : IService<MedicalRecord>
   {
      Model.Appointment.MedicalRecord AddTreatment(Model.Treatment.Treatment treatment, Model.Appointment.MedicalRecord medRec);
      Model.Appointment.MedicalRecord GetMedRecByPatient(Model.SystemUsers.Patient patient);
      Model.Appointment.MedicalRecord GetMedRecByTreatment(Model.Treatment.Treatment treatment);
      MedicalRecord getMedRecById(long id);
      List<MedicalRecord> getAllAvailablePatientsForRehabilitation();
    }
}