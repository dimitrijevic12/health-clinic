/***********************************************************************
 * Module:  IWorkingScheduleService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IWorkingScheduleService
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Service
{
   public interface IWorkingScheduleService : IService<WorkingSchedule>
   {
      List<WorkingSchedule> GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day);
   }
}