﻿using Model.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.View.Converter
{
    class AppointmentConverter : AbstractConverter
    {
        public static string ConvertAppointmentToString(Appointment appointment)
            => string.Join(" ", appointment.Id, appointment.Patient, appointment.Doctor, appointment.ExamOperationRoom);

        public static IList<string> ConvertAppointmentListToStringList(IList<Appointment> appointments)
            => ConvertEntityListToViewList(appointments, ConvertAppointmentToString);
    }
}
