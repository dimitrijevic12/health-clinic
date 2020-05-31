/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class AppointmentRepository : IAppointmentRepository
   {
      public AppointmentRepository GetInstance() { return null; }

        public Appointment GetAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public List<DateTime> GetDatesForAppointmentsInRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public List<TermDTO> GetTermsByDoctorAndDatePeriod(DateTime dateFrom, DateTime dateTo, Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<TermDTO> GetNewTermsForDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public Appointment Save(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment Edit(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        private String Path;
      private static AppointmentRepository Instance;
   
   }
}