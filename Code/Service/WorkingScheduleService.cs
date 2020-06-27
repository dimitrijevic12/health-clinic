/***********************************************************************
 * Module:  WorkingScheduleService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.WorkingScheduleService
 ***********************************************************************/

using Model.SystemUsers;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class WorkingScheduleService : IWorkingScheduleService
   {
        public readonly IWorkingScheduleRepository _workingScheduleRepository = WorkingScheduleRepository.Instance;

        private static WorkingScheduleService instance;

        public static WorkingScheduleService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkingScheduleService();
                }
                return instance;
            }
        }

        private WorkingScheduleService()
        {
        }

        public WorkingScheduleService(IWorkingScheduleRepository repository)
        {
            _workingScheduleRepository = repository;
        }

        public List<WorkingSchedule> GetWorkingScheduleByDoctor(Doctor doctor)
        {
            var workSc = _workingScheduleRepository.GetWorkingSchedulebyDoctor(doctor);
            //fali red
            return workSc;
           
        }

        public List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Create(WorkingSchedule obj)
        {           
            var newWorkSc = _workingScheduleRepository.Save(obj);
            
            return newWorkSc;
        }

        public WorkingSchedule Edit(WorkingSchedule obj)
        {
            return _workingScheduleRepository.Edit(obj);
        }

        public bool Delete(WorkingSchedule obj)
        {
            return _workingScheduleRepository.Delete(obj);
        }

        public List<WorkingSchedule> GetAll()
        {
            var workingSchedules = _workingScheduleRepository.GetAll();           
            return workingSchedules;
        }

     
    }
}