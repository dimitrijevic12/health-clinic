/***********************************************************************
 * Module:  IMedicalRecordRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IMedicalRecordRepository
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository
{
   public interface IMedicalRecordRepository : IRepository<MedicalRecord>
   {
      Model.Appointment.MedicalRecord GetMedRec(Model.SystemUsers.Patient patient);
   }
}