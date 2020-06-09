/***********************************************************************
 * Module:  WorkingScheduleCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.WorkingScheduleCSVConverter
 ***********************************************************************/

using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using System;

namespace Repository.Csv.Converter
{
   public class WorkingScheduleCSVConverter : ICSVConverter<WorkingSchedule>
   {
      private readonly string _delimiter;
      private readonly string _datetimeFormat;

        public WorkingScheduleCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
           // _datetimeFormat = datetimeFormat;
        }
        public WorkingSchedule ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            /* string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

             String genderString = tokens[1];

             Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

             Doctor doctor = new Doctor(int.Parse(tokens[1]), tokens[2], tokens[3], gender, DateTime.Now, "YES");

             return new WorkingSchedule*/
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(WorkingSchedule entity)
        {
            throw new NotImplementedException();
        }
    }
}