/***********************************************************************
 * Module:  WorkingScheduleCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.WorkingScheduleCSVConverter
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Repository.Csv.Converter
{
   public class WorkingScheduleCSVConverter : ICSVConverter<WorkingSchedule>
   {
      private String Delimiter;

        public WorkingSchedule ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(WorkingSchedule entity)
        {
            throw new NotImplementedException();
        }
    }
}