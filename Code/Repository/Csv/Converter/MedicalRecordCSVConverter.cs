/***********************************************************************
 * Module:  MedicalRecordCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.MedicalRecordCSVConverter
 ***********************************************************************/

using health_clinicClassDiagram.Model.SystemUsers;
using Model.Appointment;
using Model.SystemUsers;
using System;
using System.Windows.Forms.VisualStyles;

namespace Repository.Csv.Converter
{
   public class MedicalRecordCSVConverter : ICSVConverter<MedicalRecord>
   {
<<<<<<< HEAD
      private String _delimiter;
=======
        private String _delimiter;
>>>>>>> master

        public MedicalRecord ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());

            Patient patient = new Patient(tokens[1], tokens[2], int.Parse(tokens[3]), DateTime.Parse(tokens[4]), Gender.MALE);
<<<<<<< HEAD
            
=======

>>>>>>> master
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