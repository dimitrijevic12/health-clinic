/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class MedicalRecordRepository : IMedicalRecordRepository
   {
        private readonly ICSVStream<MedicalRecord> _stream;
        private readonly iSequencer<long> _sequencer;

        private String _path;
        private static MedicalRecordRepository Instance;
        public MedicalRecordRepository GetInstance() { return null; }

        public MedicalRecordRepository(string path, CSVStream<MedicalRecord> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<MedicalRecord> records)
        {
            return records.Count() == 0 ? 0 : records.Max(apt => apt.id);
        }

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
            _stream.AppendToFile(obj);
            return obj;
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {
            var records = _stream.ReadAll().ToList();
            records[records.FindIndex(rcrd => rcrd.patient.Equals(obj.patient))] = obj;
            _stream.SaveAll(records);

            return obj;
        }

        public bool Delete(MedicalRecord obj)
        {
            var records = _stream.ReadAll().ToList();
            var recordToRemove = records.SingleOrDefault(rcrd => rcrd.patient.Equals(obj.patient));

            if (recordToRemove != null)
            {
                records.Remove(recordToRemove);
                _stream.SaveAll(records);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MedicalRecord> GetAll()
        {
            var records = (List<MedicalRecord>)_stream.ReadAll();
            return records;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }



    }
}