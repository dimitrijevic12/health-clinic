/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using System;

namespace Repository
{
   public class MedicalRecordRepository : IMedicalRecordRepository
   {
      private String Path;

        public bool CloseFile(string path)
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

        public MedicalRecord GetMedRec(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Save(MedicalRecord obj)
        {
            throw new NotImplementedException();
        }
    }
}