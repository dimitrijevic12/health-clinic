/***********************************************************************
 * Module:  IWorkingSchedule.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IWorkingSchedule
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IWorkingSchedule : IController
   {
      List<WorkingSchedule> GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day);
   }
}