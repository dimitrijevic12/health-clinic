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
        private static MedicalRecordController instance;
        public static MedicalRecordController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalRecordController();
                }
                return instance;
            }
        }

        private readonly IMedicalRecordService _service = MedicalRecordService.Instance;

        private MedicalRecordController()
        {

        }

        public MedicalRecordController(IMedicalRecordService service)
        {
            _service = service;
        }

        public MedicalRecord AddTreatment(Treatment treatment, MedicalRecord medicalRecord)
        {
            return MedicalRecordService.Instance.AddTreatment(treatment, medicalRecord);
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

        public MedicalRecord getMedRecById(long id)
        {
            return _service.getMedRecById(id);
        }

        public List<MedicalRecord> getAllAvailablePatientsForRehabilitation()
        {
            return _service.getAllAvailablePatientsForRehabilitation();
        }
    }

}