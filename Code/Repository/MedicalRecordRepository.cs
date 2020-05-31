/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class MedicalRecordRepository : IMedicalRecordRepository
   {
      public MedicalRecordRepository GetInstance() { return null; }

        public MedicalRecord GetMedRecByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByTreatmentId()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord AddTreatmentToMedRec(Patient patient, Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord EditTreatmentInMedRec(Treatment treatment, MedicalRecord medRec)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Save(MedicalRecord obj)
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

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        private String Path;
      private static MedicalRecordRepository Instance;
   
   }
}