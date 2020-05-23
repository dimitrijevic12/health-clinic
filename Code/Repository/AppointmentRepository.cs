/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository
{
   public class AppointmentRepository : IAppointmentRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment Edit(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment GetAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Appointment Save(Appointment obj)
        {
            throw new NotImplementedException();
        }
    }
}