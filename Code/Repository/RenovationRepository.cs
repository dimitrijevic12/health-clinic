/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class RenovationRepository : IRenovationRepository
   {
      public RenovationRepository GetInstance() { return null; }

        public Renovation GetRenovation(Renovation renovation)
        {
            throw new NotImplementedException();
        }

        public Renovation Save(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public Renovation Edit(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public List<Renovation> GetAll()
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
      private static RenovationRepository Instance;
   
   }
}