using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Repository.Csv.Converter
{
    class SpecialistCSVConverter : ICSVConverter<Specialist>
    {

        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public SpecialistCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Specialist ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

            String genderString = tokens[3];

            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);


            String specializationString = tokens[5];

            Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), specializationString, true);

            Specialist specialist = new Specialist(long.Parse(tokens[0]), tokens[1], tokens[2], gender, DateTime.Now, specialization);

            return specialist;
        }

        public string ConvertEntityToCSVFormat(Specialist entity)
        {
            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname,
             entity.Gender,
             DateTime.Now,
             entity.Specialization);
        }
    }
}
