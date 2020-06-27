using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Threading.Tasks;


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

            String smenaString = tokens[5];

            TypeOfWorkingSchedule smena = (TypeOfWorkingSchedule)Enum.Parse(typeof(TypeOfWorkingSchedule), smenaString, true);

           
            DateTime dateOfBirth = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Doctor doctor = new Doctor(long.Parse(tokens[0]), tokens[1], tokens[2], gender, dateOfBirth ,smena, tokens[6], tokens[7]/*, specialization, hirurg*/);

            return doctor;
        }

        public string ConvertEntityToCSVFormat(Doctor entity)
        {
            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname,
             entity.Gender,
             /*DateTime.Now,*/
             entity.DateOfBirth.ToString("dd/MM/yyyy"),
             entity.Smena,
             entity.Username,
             entity.Password
             //entity.Spec,
            /* entity.Sur*/);
        }
    }
}
