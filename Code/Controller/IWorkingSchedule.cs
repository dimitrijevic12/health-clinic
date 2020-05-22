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
      Model.SystemUsers.WorkingSchedule[] GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      Model.SystemUsers.WorkingSchedule[] GetWorkingScheduleByDate(DateTime day);
   }
}