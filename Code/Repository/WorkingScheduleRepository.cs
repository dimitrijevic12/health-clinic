/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class WorkingScheduleRepository : IWorkingScheduleRepository
   {
      public WorkingScheduleRepository GetInstance() { return null; }

        public WorkingSchedule GetWorkingSchedule(WorkingSchedule workingSchedule)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Save(WorkingSchedule obj)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Edit(WorkingSchedule obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(WorkingSchedule obj)
        {
            throw new NotImplementedException();
        }

        public List<WorkingSchedule> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        private String Path;
      private static WorkingScheduleRepository Instance;
   
   }
}