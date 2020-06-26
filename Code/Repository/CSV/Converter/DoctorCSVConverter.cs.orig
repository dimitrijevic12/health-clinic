using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using Repository.Csv.Converter;
using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
>>>>>>> master

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

<<<<<<< HEAD
            DateTime dateOfBirth = DateTime.Parse(tokens[4]);

            String specializationString = tokens[5];

            Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), specializationString, true);

            Doctor doctor = new Doctor(long.Parse(tokens[0]), tokens[1], tokens[2], gender, dateOfBirth, specialization);
=======
            DateTime dateOfBirth = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture); 

            Doctor doctor = new Doctor(long.Parse(tokens[0]), tokens[1], tokens[2], gender, dateOfBirth);
>>>>>>> master

            return doctor;
        }

        public string ConvertEntityToCSVFormat(Doctor entity)
        {
            return string.Join(_delimiter,
             entity.Id,
             entity.Name,
             entity.Surname,
             entity.Gender,
<<<<<<< HEAD
             entity.DateOfBirth,
             entity.Spec);
=======
             entity.DateOfBirth.ToString("dd/MM/yyyy"));
>>>>>>> master
        }
    }
}
