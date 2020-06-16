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
        private Patient patient;
        private Doctor doctor;
        private ExamOperationRoom examOperationRoom;

        public long Id { get; set; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public Doctor Doctor { get => Doctor1; set => Doctor1 = value; }
        public Patient Patient { get => Patient1; set => Patient1 = value; }
        public Doctor Doctor1 { get => doctor; set => doctor = value; }
        public Patient Patient1 { get => patient; set => patient = value; }
        public String PatientPrikaz { get => Patient1.NameAndSurname; }
        public string DoctorPrikaz { get => Doctor1.NameAndSurname; }
        public ExamOperationRoom ExamOperationRoom { get => examOperationRoom; set => examOperationRoom = value; }

        public TypeOfAppointment Type  { get => type; set => type = value; }

        public long roomPrikaz { get => examOperationRoom.Id; }

        private DateTime startDate;
        private DateTime endDate;
        public TypeOfAppointment type;

        public Appointment(Doctor doctor, Patient patient, ExamOperationRoom room, TypeOfAppointment type, DateTime startDate, DateTime endDate)
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.ExamOperationRoom = room;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Appointment(long id, Doctor doctor, Patient patient, ExamOperationRoom room, TypeOfAppointment type, DateTime startDate, DateTime endDate)
        {
            Id = id;
            this.Doctor = doctor;
            this.Patient = patient;
            this.ExamOperationRoom = room;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public Appointment(Doctor doctor, Patient patient, TypeOfAppointment type)
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.Type = type;
        }

        public Appointment(Doctor doctor, Patient patient, ExamOperationRoom room, TypeOfAppointment type)
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.ExamOperationRoom = room;
            this.Type = type;
        }

        public Appointment()
        {
        }

    }
}