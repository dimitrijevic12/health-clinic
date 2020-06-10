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