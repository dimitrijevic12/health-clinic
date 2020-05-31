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

namespace Controller
{
   public class MedicalRecordController : IMedicalRecordController
   {
        public MedicalRecordController GetInstance() { return null; }
        public List<Treatment> GetAllTreatments()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord AddTreatment(Treatment treatment, MedicalRecord medRec)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<MedicalRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(MedicalRecord obj)
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

        public Service.IMedicalRecordService iMedicalRecordService;
   
      private static MedicalRecordController Instance;
   
   }
}