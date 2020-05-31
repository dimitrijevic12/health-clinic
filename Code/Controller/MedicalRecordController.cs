/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class MedicalRecordController : IMedicalRecordController
   {
        public MedicalRecordController GetInstance() { return null; }

        private readonly IMedicalRecordService _service;

        public MedicalRecordController(IMedicalRecordService service)
        {
            _service = service;
        }
        
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
            var record = _service.GetMedRecByPatient(patient);
            return record;
        }

        public List<MedicalRecord> GetAll()
        {
            var records = (List<MedicalRecord>)_service.GetAll();
            return records;
        }

        public bool Delete(MedicalRecord obj)
        {
            _service.Delete(obj);
            return true;
        }

        public MedicalRecord Create(MedicalRecord obj)
        {
            _service.Create(obj);
            return obj;
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            _service.Edit(obj);
            return obj;
        }

        public Service.IMedicalRecordService iMedicalRecordService;
   
      private static MedicalRecordController Instance;
   
   }
}