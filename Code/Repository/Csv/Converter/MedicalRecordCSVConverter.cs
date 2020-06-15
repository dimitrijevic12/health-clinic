/***********************************************************************
 * Module:  MedicalRecordCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.MedicalRecordCSVConverter
 ***********************************************************************/

using health_clinicClassDiagram.Repository;
using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Model.SystemUsers;
using Model.SystemUsers.health_clinicClassDiagram.Model.SystemUsers;
using Model.Treatment;
using Repository.Csv.Stream;
using Service;
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

            DateTime dateOfBirth = DateTime.Parse(tokens[4]);

            Patient patient = new Patient(tokens[1], tokens[2], int.Parse(tokens[3]), dateOfBirth, gender);

            long idDoctor = long.Parse(tokens[6]);

            var doctorRepository = new DoctorRepository(
                "../../Resources/Data/doctors.csv",
                new CSVStream<Doctor>("../../Resources/Data/doctors.csv", new DoctorCSVConverter(",", "dd.MM.yyyy.")),
                new LongSequencer());

            Doctor doctor = new Doctor(idDoctor, tokens[7], tokens[8]);
            List<Treatment> treatments = new List<Treatment>();

            /*if (!tokens[9].Equals(""))
            {
                String treatmentsString = tokens[9];
                String[] treatmentsParts = treatmentsString.Split(',');
                treatments = new List<Treatment>();
                if (treatmentsString != "")
                {
                    foreach (String id in treatmentsParts)
                    {
                        //                treatmentIds.Add(long.Parse(id));
                        //                treatments.Add(MedicalRecordRepository.Instance.GetTreatmentByTreatmentId(long.Parse(id)));
                        treatments.Add(TreatmentRepository.Instance.GetTreatment(long.Parse(id)));

                    }
                }
            }*/

            int i = 9;

            //Console.WriteLine(TreatmentRepository.Instance.GetAll().Count);
            foreach (Treatment treat in TreatmentRepository.Instance.GetAll())
            {
                Console.WriteLine(treat.Id);
                Console.WriteLine(treat.DiagnosisAndReview.Review);
                Console.WriteLine(treat.Doctor.NameDoctor);
            }

            while (i < tokens.Length - 1)
            {
                long id = long.Parse(tokens[i]);

                //Console.WriteLine(id);

                //Console.WriteLine(TreatmentRepository.Instance.GetTreatment(id).Id);

                treatments.Add(TreatmentRepository.Instance.GetTreatment(id));

                i++;
            }



            return new MedicalRecord(
                long.Parse(tokens[0]),
                patient,
                doctor,
                treatments); //ne treba new doctor treba promeniti (tokens[6]), kao i u patient u Gender.MALE
        }

        public string ConvertEntityToCSVFormat(MedicalRecord entity)
        {
            /*String treatments = "";
            if (entity.Treatments != null)
            {
                foreach (Treatment treatment in entity.Treatments)
                {
                    if (treatment != null)
                    {
                        treatments += treatment.Id + ",";
                    }
                }

            }*/


            String resenje = "";


            foreach (Treatment treatment in entity.Treatments)
            {
                resenje += string.Join(_delimiter, treatment.Id);
                resenje += _delimiter;
            }

            /*return string.Join(_delimiter,
              entity.id,
              entity.Patient.Name,
              entity.Patient.Surname,
              entity.Patient.Id,
              DateTime.DateOfBirth,
              entity.Patient.Gender,
              entity.choosenDoctor.Id,
              entity.choosenDoctor.NameDoctor,
              entity.choosenDoctor.SurnameDoctor,
              treatments);*/

            return string.Join(_delimiter,
              entity.id,
              entity.Patient.Name,
              entity.Patient.Surname,
              entity.Patient.Id,
              entity.DateOfBirth,
              entity.Patient.Gender,
              entity.choosenDoctor.Id,
              entity.choosenDoctor.NameDoctor,
              entity.choosenDoctor.SurnameDoctor,
              resenje);

        }
    }

}