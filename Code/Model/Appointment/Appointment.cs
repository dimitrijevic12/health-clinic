/***********************************************************************
 * Module:  Appointment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.Appointment
 ***********************************************************************/

using Model.Rooms;
using Model.SystemUsers;
using System;
using System.ComponentModel;

namespace Model.Appointment
{
<<<<<<< HEAD
   public class Appointment : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public Model.SystemUsers.Patient patient;
        public Model.SystemUsers.Doctor doctor;
        public Model.Rooms.ExamOperationRoom examOperationRoom;

        public long Id { get; set; }
=======
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
        public ExamOperationRoom ExamOperationRoom { get => examOperationRoom; set => examOperationRoom = value; }
>>>>>>> master

        public DateTime StartDate;
        public DateTime EndDate;
        public TypeOfAppointment Type;

        public DateTime Start
        {
            get
            {
                return StartDate;
            }
            set
            {
                if (!value.Equals(StartDate))
                {
                    StartDate = value;
                    OnPropertyChanged("StartDate");
                }
            }
        }

        public DateTime End
        {
            get
            {
                return EndDate;
            }
            set
            {
                if (!value.Equals(EndDate))
                {
                    EndDate = value;
                    OnPropertyChanged("EndDate");
                }
            }
        }

        public Appointment(Doctor doctor, Patient patient, ExamOperationRoom room, TypeOfAppointment type, DateTime startDate, DateTime endDate)
        {
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