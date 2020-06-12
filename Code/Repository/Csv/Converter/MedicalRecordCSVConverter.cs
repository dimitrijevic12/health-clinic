/***********************************************************************
 * Module:  MedicalRecordCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.MedicalRecordCSVConverter
 ***********************************************************************/

using Model.Appointment;
using Model.SystemUsers;
<<<<<<< HEAD
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
=======
using Model.Treatment;
>>>>>>> master
using System;
using System.Collections.Generic;

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

            String genderString = tokens[5];

            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderString, true);

            Patient patient = new Patient(tokens[1], tokens[2], int.Parse(tokens[3]), DateTime.Now, gender);

            String treatmentsString = tokens[7];
            String[] treatmentsParts = treatmentsString.Split(',');
            List<Treatment> treatments = new List<Treatment>();
            foreach(String id in treatmentsParts)
            {
                //                treatmentIds.Add(long.Parse(id));
                //                treatments.Add(MedicalRecordRepository.Instance.GetTreatmentByTreatmentId(long.Parse(id)));
                treatments.Add(TreatmentRepository.Instance.GetTreatment(long.Parse(id)));

            }

            return new MedicalRecord(
                long.Parse(tokens[0]),
                patient,
                new Doctor(),
                treatments); //ne treba new doctor treba promeniti (tokens[6]), kao i u patient u Gender.MALE
        }

        public string ConvertEntityToCSVFormat(MedicalRecord entity)
        {
            String treatments = "";
            foreach (Treatment treatment in entity.Treatments)
            {
                treatments += treatment.Id + ",";
            }

            return string.Join(_delimiter,
              entity.id,
              entity.Patient.Name,
              entity.Patient.Surname,
              entity.Patient.Id,
              DateTime.Now,
              entity.Patient.Gender,
              entity.choosenDoctor,
              treatments);
        }
    }

}