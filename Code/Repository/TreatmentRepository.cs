/***********************************************************************
 * Module:  TreatmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.TreatmentRepository
 ***********************************************************************/

using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class TreatmentRepository : ITreatmentRepository
   {
      public TreatmentRepository GetInstance() { return null; }

        public Treatment GetTreatment()
        {
            throw new NotImplementedException();
        }

        public Treatment Save(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment Edit(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Treatment obj)
        {
            throw new NotImplementedException();
        }

        public List<Treatment> GetAll()
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

        private static TreatmentRepository Instance;
      private String Path;
   
   }
}