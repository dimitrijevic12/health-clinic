using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

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

            DateTime dateOfBirth = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            string username = tokens[5];

            string password = tokens[6];

            Doctor doctor = new Doctor(long.Parse(tokens[0]), tokens[1], tokens[2], gender, dateOfBirth, username, password);

            return doctor;
        }

        public string ConvertEntityToCSVFormat(Doctor entity)
        {
            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname,
             entity.Gender,
             entity.DateOfBirth.ToString("dd/MM/yyyy"),
             entity.Username,
             entity.Password);
        }
    }
}
