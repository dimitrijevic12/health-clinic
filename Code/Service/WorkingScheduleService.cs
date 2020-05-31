/***********************************************************************
 * Module:  WorkingScheduleService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.WorkingScheduleService
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Service
{
   public class WorkingScheduleService : IWorkingScheduleService
   {
      public WorkingScheduleService GetInstance() { return null; }

        public List<WorkingSchedule> GetWorkingScheduleByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Create(WorkingSchedule obj)
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

        public Repository.IWorkingScheduleRepository iWorkingScheduleRepository;
   
      private static WorkingScheduleService Instance;
   
   }
}