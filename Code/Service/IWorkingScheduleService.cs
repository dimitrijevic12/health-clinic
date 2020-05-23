/***********************************************************************
 * Module:  IWorkingScheduleService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IWorkingScheduleService
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Service
{
   public interface IWorkingScheduleService : IService<WorkingSchedule>
   {
      Model.SystemUsers.WorkingSchedule[] GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      Model.SystemUsers.WorkingSchedule[] GetWorkingScheduleByDate(DateTime day);
   }
}