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
      Model.SystemUsers.WorkingSchedule[] GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      Model.SystemUsers.WorkingSchedule[] GetWorkingScheduleByDate(DateTime day);
   }
}