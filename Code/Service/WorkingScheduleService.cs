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
        public readonly IWorkingScheduleRepository iWorkingScheduleRepository;
        private readonly IService<Doctor> _DoctorService;

        private static WorkingScheduleService Instance;
        public WorkingScheduleService GetInstance() { return null; }

        public WorkingScheduleService(IWorkingScheduleRepository repository, IService<Doctor> service)
        {
            iWorkingScheduleRepository = repository;
            _DoctorService = service;
        }

        public List<WorkingSchedule> GetWorkingScheduleByDoctor(Doctor doctor)
        {
            var workSc = iWorkingScheduleRepository.GetWorkingSchedulebyDoctor(doctor);
            //fali red
            return workSc;
            return null;
        }

        public List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day)
        {
            throw new NotImplementedException();
        }

        public WorkingSchedule Create(WorkingSchedule obj)
        {           
            var newWorkSc = iWorkingScheduleRepository.Save(obj);
            
            return newWorkSc;
        }

        public WorkingSchedule Edit(WorkingSchedule obj)
        {        
            iWorkingScheduleRepository.Edit(obj);
            return obj;
        }

        public bool Delete(WorkingSchedule obj)
        {
            iWorkingScheduleRepository.Delete(obj);
            return true;
        }

        public List<WorkingSchedule> GetAll()
        {
            var list = iWorkingScheduleRepository.GetAll();
            
            return list;
        }

     
    }
}