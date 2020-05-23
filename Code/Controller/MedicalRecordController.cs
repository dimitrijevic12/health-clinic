/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using System;

namespace Controller
{
   public class MedicalRecordController : IMedicalRecordController
   {
      public Service.MedicalRecordService medicalRecordService;

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

        public MedicalRecord GetAll()
        {
            throw new NotImplementedException();
        }

        public Treatment[] GetAllTreatments()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}