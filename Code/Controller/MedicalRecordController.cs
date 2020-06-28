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
        private static MedicalRecordController Instance;
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
            MedicalRecord record = _service.GetMedRecByPatient(patient);
            return record;
        }

        public List<MedicalRecord> GetAll()
        {
            List<MedicalRecord> records = (List<MedicalRecord>)_service.GetAll();
            return records;
        }

        public bool Delete(MedicalRecord obj)
        {
            return _service.Delete(obj);
        }

        public MedicalRecord Create(MedicalRecord obj)
        {
            return _service.Create(obj);
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            return _service.Edit(obj);
        }

    }
}