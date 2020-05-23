/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using System;

namespace Service
{
   public class MedicalRecordService : IMedicalRecordService
   {
      public Repository.MedicalRecordRepository medicalRecordRepository;

        public MedicalRecord AddTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Create(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord[] GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }
    }
}