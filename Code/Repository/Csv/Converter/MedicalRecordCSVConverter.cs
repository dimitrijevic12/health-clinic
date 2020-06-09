/***********************************************************************
 * Module:  MedicalRecordCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.MedicalRecordCSVConverter
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using System;

namespace Repository.Csv.Converter
{
    public class MedicalRecordCSVConverter : ICSVConverter<MedicalRecord>
   {
      
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public MedicalRecordCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public MedicalRecord ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

            Patient patient = new Patient(tokens[1], tokens[2], int.Parse(tokens[3]), DateTime.Parse(tokens[4]), Gender.MALE);

            return new MedicalRecord(
                long.Parse(tokens[0]),
                patient,
                new Doctor()); //ne treba new doctor treba promeniti (tokens[6]), kao i u patient u Gender.MALE
        }

        public string ConvertEntityToCSVFormat(MedicalRecord entity)
        {
            return string.Join(_delimiter,
              entity.id,
              entity.patient,
              entity.choosenDoctor);
        }
    }

}