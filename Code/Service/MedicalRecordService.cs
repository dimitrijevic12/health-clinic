/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class MedicalRecordService : IMedicalRecordService
   {
        private readonly IMedicalRecordRepository _medicalRecordRepository;
        private readonly IUserService _patientService;
        private static MedicalRecordService Instance;
        public MedicalRecordService GetInstance() { return null; }

        public MedicalRecordService(IMedicalRecordRepository repository, IUserService service)
        {
            _medicalRecordRepository = repository;
            _patientService = service;
        }

        public MedicalRecord AddTreatment(Treatment treatment, MedicalRecord medRec)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedRecByPatient(Patient patient)
        {
            var record = _medicalRecordRepository.GetMedRecByPatient(patient);
            //fali red
            return record;

        }

        public MedicalRecord GetMedRecByTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Create(MedicalRecord obj)
        {
            var _user = _patientService.Create(obj.patient);
            var patient = (Patient)_user;
            var newMedicalRecord = _medicalRecordRepository.Save(obj);
            newMedicalRecord.patient = patient;
            return newMedicalRecord;
            //fali treatment ali to vrv u add treatment
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            _patientService.Edit(obj.patient);
            _medicalRecordRepository.Edit(obj);
            return obj;
        }

        public bool Delete(MedicalRecord obj)
        {
            _patientService.Delete(obj.patient);
            _medicalRecordRepository.Delete(obj);
            return true;
        }

        public List<MedicalRecord> GetAll()
        {
            var patients = _patientService.GetAll();
            var records = _medicalRecordRepository.GetAll();
            //BindPatientsWithRecords(patients, records);
            return records;
        }

        private void BindPatientsWithRecords(Patient[] patients, MedicalRecord[] records)
        {
            //records.ToList().ForEach(record => record.patient = GetMedRecByPatient(record.patient));
        }

        public Repository.IMedicalRecordRepository iMedicalRecordRepository;


    }

}