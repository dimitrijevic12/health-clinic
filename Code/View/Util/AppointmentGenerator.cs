﻿using Model.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View.Util
{
    public class AppointmentGenerator
    {
        private static AppointmentGenerator instance = null;

        public static AppointmentGenerator Instance 
        { get
            {
                if (instance == null)
                {
                    instance = new AppointmentGenerator();
                }
                return instance;

            }
        }

        public List<Appointment> generateList(DateTime date)
        {
            List<Appointment> blankAppointments = new List<Appointment>();
 //           DateTime startDate = date;
 //           DateTime endDate = date;

            double testDouble = 0.0;
            DateTime test = date.AddHours(testDouble +  3.0);

            for (double i = 0.0; i < 24.0; i+=1.0)
            {
                DateTime startDate = date.AddHours(i);
                DateTime endDate = date.AddHours(i + 1.0);

                Appointment temp = new Appointment(null, null, null,  0, startDate, endDate);
                blankAppointments.Add(temp);
            }

            return blankAppointments;
        }
    }
}
