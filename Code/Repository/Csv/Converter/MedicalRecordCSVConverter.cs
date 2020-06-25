/***********************************************************************
 * Module:  MedicalRecordCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.MedicalRecordCSVConverter
 ***********************************************************************/

using health_clinicClassDiagram.Model.SystemUsers;
using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;
using System.Linq;

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

            //Patient patient = new Patient(tokens[1], tokens[2], long.Parse(tokens[3]), dateOfBirth, gender);

            long idDoctor = long.Parse(tokens[6]);

            /*var doctorRepository = new DoctorRepository(
                "../../Resources/Data/doctors.csv",
                new CSVStream<Doctor>("../../Resources/Data/doctors.csv", new DoctorCSVConverter(",", "dd.MM.yyyy.")),
                new LongSequencer());
            var patientRepository = new PatientRepository(
                "../../Resources/Data/patients.csv",
                new CSVStream<Patient>("../../Resources/Data/patients.csv", new PatientCSVConverter(",", "dd.MM.yyyy.")),
                new LongSequencer()); */

            var doctorRepository = DoctorRepository.Instance;
            var patientRepository = PatientRepository.Instance;

            //Doctor doctor = new Doctor(idDoctor, tokens[7], tokens[8]);
            Doctor doctor = doctorRepository.GetDoctorById(idDoctor);
            Patient patient = patientRepository.getPatientById(long.Parse(tokens[3]));
            List<Treatment> treatments = new List<Treatment>();

            int i = 9;
            /*int flag = 0;
            if (tokens.Length >= 10)
            {
                if (tokens[9] != "")
                {
                    long id = long.Parse(tokens[9]);
                    treatments.Add(TreatmentRepository.Instance.GetTreatment(id));
                }
            }
            if (tokens.Length >= 11)
            {
                if (tokens[10] != "")
                {
                    long id = long.Parse(tokens[10]);
                    treatments.Add(TreatmentRepository.Instance.GetTreatment(id));
                }
            }*/


            /*while (i <= tokens.Length-1)
            {
                long id = long.Parse(tokens[i]);
                treatments.Add(TreatmentRepository.Instance.GetTreatment(id));
                i++;
            }*/

            if (tokens[9] != "")
            {
                String treatmentsString = tokens[9];

                String[] oneTreatment = treatmentsString.Split('|');

                Console.WriteLine(oneTreatment.Length);

                for (int j = 0; j < oneTreatment.Length; j++)
                {
                    treatments.Add(TreatmentRepository.Instance.GetTreatment(long.Parse(oneTreatment[j])));
                }
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

            Treatment last = entity.Treatments.Last();
            foreach (Treatment treatment in entity.Treatments)
            {
                if(treatment != last)
                {
                    resenje += treatment.Id + "|";
                }
                else
                {
                    resenje += treatment.Id;
                }
            }       

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