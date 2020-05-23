/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Treatment;
using System;

namespace Repository
{
   public class TreatmentRepository : ITreatmentRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment Edit(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Treatment GetTreatment(Treatment treatment)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Treatment Save(Treatment obj)
        {
            throw new NotImplementedException();
        }
    }
}