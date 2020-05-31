/***********************************************************************
 * Module:  IWorkingScheduleService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IWorkingScheduleService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IWorkingScheduleService : IService
   {
      List<WorkingSchedule> GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day);
   }
}