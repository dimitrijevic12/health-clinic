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

namespace Controller
{
   public class MedicalRecordController : IMedicalRecordController
   {
      public Service.MedicalRecordService medicalRecordService;

        private readonly IMedicalRecordService _service;

        public MedicalRecordController(IMedicalRecordService service)
        {
            _service = service;
        }

        public MedicalRecord AddTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Create(MedicalRecord obj)
        {
            _service.Create(obj);
            return obj;
        }

        public bool Delete(MedicalRecord obj)
        {
            _service.Delete(obj);
            return true;
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            _service.Edit(obj);
            return obj;
        }

        public MedicalRecord[] GetAll()
        {
            var records = (MedicalRecord[]) _service.GetAll();
            return records;
        }

        public Treatment[] GetAllTreatments()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByPatient(Patient patient)
        {
           var record = _service.GetMedRecByPatient(patient);
           return record;
        }

    }
}