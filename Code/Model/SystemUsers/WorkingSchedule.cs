/***********************************************************************
 * Module:  WorkingSchedule.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.WorkingSchedule
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model.SystemUsers
{
   public class WorkingSchedule
   {
        private List<WorkingDays> workingDays;
   
        private DateTime from;
        private DateTime to;
        private long id;

        public WorkingSchedule(long id, DateTime from, DateTime to, List<WorkingDays> workingDays)
        {
            From = from;
            To = to;
            WorkingDays = workingDays;
            Id = id;
        }

        public DateTime From { get => from; set => from = value; }
        public DateTime To { get => to; set => to = value; }
        public List<WorkingDays> WorkingDays { get => workingDays; set => workingDays = value; }
        public long Id { get => id; set => id = value; }
    }
}