/***********************************************************************
 * Module:  Appointment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.Appointment
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using System;

namespace Model.Appointment
{
   public class Appointment
   {
        public Model.SystemUsers.Patient patient;
        public Model.SystemUsers.Doctor doctor;
        public Model.Rooms.ExamOperationRoom examOperationRoom;

        public long Id { get; set; }

        public DateTime StartDate;
        public DateTime EndDate;
        public TypeOfAppointment Type;

        public Appointment(Doctor doctor, Patient patient, ExamOperationRoom room, TypeOfAppointment type, DateTime startDate, DateTime endDate)
        {
            this.doctor = doctor;
            this.patient = patient;
            this.examOperationRoom = room;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Appointment(Doctor doctor, Patient patient, TypeOfAppointment type)
        {
            this.doctor = doctor;
            this.patient = patient;
            this.Type = type;
        }

        public Appointment(Doctor doctor, Patient patient, ExamOperationRoom room, TypeOfAppointment type)
        {
            this.doctor = doctor;
            this.patient = patient;
            this.examOperationRoom = room;
            this.Type = type;
        }

    }
}