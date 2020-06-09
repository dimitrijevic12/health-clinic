/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.SystemUsers;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class WorkingScheduleRepository : IWorkingScheduleRepository
   {
        private String Path;
        private static WorkingScheduleRepository Instance;

        private readonly ICSVStream<WorkingSchedule> _stream;
        private readonly iSequencer<long> _sequencer;
        public WorkingScheduleRepository GetInstance() { return null; }

        public WorkingScheduleRepository(string path, ICSVStream<WorkingSchedule> stream, iSequencer<long> sequencer)
        {
            Path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<WorkingSchedule> list)
        {
            return list.Count() == 0 ? 0 : list.Max(li => li.Id);
        }

        public WorkingSchedule GetWorkingSchedule(WorkingSchedule workingSchedule)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Save(WorkingSchedule obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public WorkingSchedule Edit(WorkingSchedule obj)
        {
            var list = _stream.ReadAll().ToList();
            list[list.FindIndex(li => li.Id == obj.Id)] = obj;
            _stream.SaveAll(list);

            return obj;
        }

        public bool Delete(WorkingSchedule obj)
        {
            var list = _stream.ReadAll().ToList();
            var listToRemove = list.SingleOrDefault(li => li.Id == obj.Id);

            if (listToRemove != null)
            {
                list.Remove(listToRemove);
                _stream.SaveAll(list);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<WorkingSchedule> GetAll()
        {
            var list = (List<WorkingSchedule>)_stream.ReadAll();
            return list;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public List<WorkingSchedule> GetWorkingSchedulebyDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

      
    }
}