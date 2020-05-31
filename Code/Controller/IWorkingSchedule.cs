/***********************************************************************
 * Module:  IWorkingSchedule.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IWorkingSchedule
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Controller
{
   public interface IWorkingSchedule : IController<WorkingSchedule>
   {
      List<WorkingSchedule> GetWorkingScheduleByDoctor(Model.SystemUsers.Doctor doctor);
      List<WorkingSchedule> GetWorkingScheduleByDate(DateTime day);
   }
}