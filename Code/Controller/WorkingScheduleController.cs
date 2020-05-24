/***********************************************************************
 * Module:  WorkingScheduleService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.WorkingScheduleService
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Controller
{
   public class WorkingScheduleController : IWorkingSchedule
   {
      public Service.WorkingScheduleService workingScheduleService;

        public WorkingSchedule Create(WorkingSchedule obj)
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

        public WorkingSchedule[] GetWorkingScheduleByDate(DateTime day)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule[] GetWorkingScheduleByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}