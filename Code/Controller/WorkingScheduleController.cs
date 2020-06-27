/***********************************************************************
 * Module:  WorkingScheduleService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.WorkingScheduleService
 ***********************************************************************/

using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class WorkingScheduleController : IWorkingSchedule
   {
      public WorkingScheduleController GetInstance() { return null; }
        public IWorkingScheduleService _service = WorkingScheduleService.Instance;

        private static WorkingScheduleController instance;

        public static WorkingScheduleController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkingScheduleController();
                }
                return instance;
            }
        }

        private WorkingScheduleController()
        {
        }
        public List<WorkingSchedule> GetWorkingScheduleByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day)
        {
            throw new NotImplementedException();
        }

        public List<WorkingSchedule> GetAll()
        {
            var workingSchedules = (List<WorkingSchedule>)_service.GetAll();
            return workingSchedules;
        }

        public bool Delete(WorkingSchedule obj)
        {
            return _service.Delete(obj);
        }

        public WorkingSchedule Create(WorkingSchedule obj)
        {
            return _service.Create(obj);
        }

        public WorkingSchedule Edit(WorkingSchedule obj)
        {
            return _service.Edit(obj);
        }


    }
}