using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
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

            String genderString = tokens[1];

            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

            Doctor doctor = new Doctor(int.Parse(tokens[1]), tokens[2], tokens[3], gender, DateTime.Now, "YES");

            return doctor;
        }

        public string ConvertEntityToCSVFormat(Doctor entity)
        {
            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname);
        }
    }
}
