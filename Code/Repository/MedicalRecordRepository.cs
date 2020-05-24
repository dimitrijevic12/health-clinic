/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.CSV.Stream;
using Model.Appointment;
using Model.SystemUsers;
using Service;
using System;
using System.Linq;

namespace Repository
{
   public class MedicalRecordRepository : IMedicalRecordRepository
   {
        private string _path;

        private readonly ICSVStream<MedicalRecord> _stream;
        //private readonly ISequencer<long> _sequencer;

        public MedicalRecordRepository(string path, CSVStream<MedicalRecord> stream)
        {
            _path = path;
            _stream = stream;
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
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
            } else
            {
                return false;
            }
        }

        public MedicalRecord Edit(MedicalRecord obj)
        {          
            var records = _stream.ReadAll().ToList();
            records[records.FindIndex(rcrd => rcrd.patient.Equals(obj.patient))] = obj;
            _stream.SaveAll(records);
           
            return obj;
        }

        public MedicalRecord[] GetAll()
        {
            var records = (MedicalRecord[]) _stream.ReadAll();
            return records;
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
            _stream.AppendToFile(obj);
            return obj;
        }
    }
}