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
    class SurgeonCSVConverter : ICSVConverter<Surgeon>
    {

        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public SurgeonCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Surgeon ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

            String genderString = tokens[3];

            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

            DateTime date = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            String specializationString = tokens[5];

            SurgicalSpecialty surgicalSpecialty = (SurgicalSpecialty)Enum.Parse(typeof(SurgicalSpecialty), specializationString, true);

            Surgeon surgeon = new Surgeon(long.Parse(tokens[0]), tokens[1], tokens[2], gender, DateTime.Now, surgicalSpecialty);

            return surgeon;
        }

        public string ConvertEntityToCSVFormat(Surgeon entity)
        {
            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname,
             entity.Gender,
             entity.DateOfBirth.ToString("dd/MM/yyyy"),
             entity.SurgicalSpecialty);
        }
    }
}
