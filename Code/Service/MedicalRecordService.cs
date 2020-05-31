/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Service
{
   public class MedicalRecordService : IMedicalRecordService
   {
      public MedicalRecordService GetInstance() { return null; }

        public MedicalRecord AddTreatment(Treatment treatment, MedicalRecord medRec)
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

        public MedicalRecord Create(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }

        public List<MedicalRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public Repository.IMedicalRecordRepository iMedicalRecordRepository;
   
      private static MedicalRecordService Instance;
   
   }
}