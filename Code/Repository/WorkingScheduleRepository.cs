/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Repository
{
   public class WorkingScheduleRepository : IWorkingScheduleRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(WorkingSchedule obj)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Edit(WorkingSchedule obj)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule[] GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule GetWorkingSchedule(WorkingSchedule workingSchedule)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Save(WorkingSchedule obj)
        {
            throw new NotImplementedException();
        }
    }
}