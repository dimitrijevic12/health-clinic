/***********************************************************************
 * Module:  WorkingSchedule.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.WorkingSchedule
 ***********************************************************************/

using System;

namespace Model.SystemUsers
{
   public class WorkingSchedule
   {
      public WorkingDays[] workingDays;
   
      private DateTime From;
      private DateTime To;

        public long Id { get; set; }
    }
}