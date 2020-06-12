using Model.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.View.Converter
{
    class MedicalRecordConverter : AbstractConverter
    {
        public static string ConvertMedicalRecordToString(MedicalRecord record)
            => string.Join(" ", record.Patient, record.Doctor, record.Treatments);

        public static IList<string> ConvertMedicalRecordListToStringList(IList<MedicalRecord> records)
            => ConvertEntityListToViewList(records, ConvertMedicalRecordToString);
    }
}
