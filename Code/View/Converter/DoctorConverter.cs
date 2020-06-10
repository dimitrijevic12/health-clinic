using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.View.Converter
{
    class DoctorConverter : AbstractConverter
    {
        public static string ConvertMedicalRecordToString(Doctor doctor)
            => string.Join(" ", doctor);

        public static IList<string> ConvertMedicalRecordListToStringList(IList<Doctor> doctors)
            => ConvertEntityListToViewList(doctors, ConvertMedicalRecordToString);
    }
}
