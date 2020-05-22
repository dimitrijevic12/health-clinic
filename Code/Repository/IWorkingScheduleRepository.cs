/***********************************************************************
 * Module:  IWorkingScheduleRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IWorkingScheduleRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IWorkingScheduleRepository : IRepository
   {
      Model.SystemUsers.WorkingSchedule GetWorkingSchedule(Model.SystemUsers.WorkingSchedule workingSchedule);
   }
}