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
      Model.Appointment.MedicalRecord GetMedRec(Model.SystemUsers.Patient patient);
   }
}