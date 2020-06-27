/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using health_clinicClassDiagram.Repository;
using health_clinicClassDiagram.Service;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
   public class MedicalRecordService : IMedicalRecordService
   {
        private readonly IMedicalRecordRepository _medicalRecordRepository = MedicalRecordRepository.Instance;
        private readonly IService<Patient> _patientService = PatientService.Instance;
        private static MedicalRecordService instance;

        public static MedicalRecordService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MedicalRecordService();
                }
                return instance;
            }
        }

        private MedicalRecordService()
        {

        }


        public MedicalRecordService(IMedicalRecordRepository repository, IService<Patient> service)
        {
            _medicalRecordRepository = repository;
            _patientService = service;
        }

        public MedicalRecord AddTreatment(Treatment treatment, MedicalRecord medicalRecord)
        {
            return MedicalRecordRepository.Instance.AddTreatmentToMedicalRecord(medicalRecord, treatment);
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            var record = _medicalRecordRepository.GetMedicalRecordByPatient(patient);
            return record;

        }

        public MedicalRecord Create(MedicalRecord obj)
        {
            var _user = _patientService.Create(obj.Patient);
            var patient = (Patient)_user;
            var newMedicalRecord = _medicalRecordRepository.Save(obj);
            newMedicalRecord.Patient = patient;
            return newMedicalRecord;
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            _patientService.Edit(obj.Patient);
            _medicalRecordRepository.Edit(obj);
            return obj;
        }

        public bool Delete(MedicalRecord obj)
        {
            _patientService.Delete(obj.Patient);
            _medicalRecordRepository.Delete(obj);
            return true;
        }

        public List<MedicalRecord> GetAll()
        {
            var records = _medicalRecordRepository.GetAll();
            return records;
        }
        public MedicalRecord GetMedicalRecordById(long id)
        {
            return _medicalRecordRepository.GetMedicalRecordById(id);
        }

        public List<MedicalRecord> GetAllAvailablePatientsForRehabilitation()
        {
            var records = _medicalRecordRepository.GetAll();
            var rehabilitationRooms = RehabilitationRoomRepository.Instance.GetAll();

            List<MedicalRecord> placed = new List<MedicalRecord>();

            foreach (RehabilitationRoom room in rehabilitationRooms)
            {
                placed.AddRange(room.Patients);
            }

            foreach (MedicalRecord record in placed)
            {
                var item = records.SingleOrDefault(x => x.Id == record.Id);
                if (item != null)
                    records.Remove(item);
            }
            return records;
        }



    }

}