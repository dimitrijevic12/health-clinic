﻿using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using Repository;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace health_clinicClassDiagram.Repository.Csv.Converter
{
    class DoctorCSVConverter : ICSVConverter<Doctor>
    {

        private String Delimiter;

        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public DoctorCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Doctor ConvertCSVFormatToEntity(string entityCSVFormat)
        {

            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

            String genderString = tokens[3];

            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

            List<WorkingSchedule> workingSchedules = new List<WorkingSchedule>();

            if (tokens[5] != "")
            {
                String workingString = tokens[5];

                String[] oneString = workingString.Split('|');

                for (int j = 0; j < oneString.Length; j++)
                {
                    workingSchedules.Add(WorkingScheduleRepository.Instance.GetWorkingShceduleById(long.Parse(oneString[j])));
                }
            }


            DateTime dateOfBirth = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Doctor doctor = new Doctor(long.Parse(tokens[0]), tokens[1], tokens[2], gender, dateOfBirth, workingSchedules, tokens[6], tokens[7]/*, specialization, hirurg*/);

            return doctor;
        }

        public string ConvertEntityToCSVFormat(Doctor entity)
        {
            String schedules = "";

            if (entity.WorkingSchedules.Count != 0)
            {
                WorkingSchedule last = entity.WorkingSchedules.Last();
                foreach (WorkingSchedule schedule in entity.WorkingSchedules)
                {
                    if (schedule != null)
                    {
                        if (schedule != last)
                        {
                            schedules += schedule.Id + "|";
                        }
                        else
                        {
                            schedules += schedule.Id;
                        }
                    }
                }
            }

            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname,
             entity.Gender,
             entity.DateOfBirth.ToString("dd/MM/yyyy"),
             schedules,
             entity.Username,
             entity.Password);
        }
    }
}