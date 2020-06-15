using health_clinicClassDiagram.Model.SystemUsers;
using Model.SystemUsers;
using Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            String specializationString = tokens[6];

            Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), specializationString, true);

            String hirurgString = tokens[7];

            SurgicalSpecialty hirurg = (SurgicalSpecialty)Enum.Parse(typeof(SurgicalSpecialty), hirurgString, true);

            Doctor doctor = new Doctor(long.Parse(tokens[0]), tokens[1], tokens[2], gender, /*DateTime.Now*/ tokens[4] ,smena, specialization, hirurg);

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
             entity.DateOfBirth,
             entity.Smena,
             entity.Spec,
             entity.Sur);
        }
    }
}
