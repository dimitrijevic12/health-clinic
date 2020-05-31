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
   public class DrugRepository : IDrugRepository
   {
      public DrugRepository GetInstance() { return null; }

        public Drug GetDrug(Drug drug)
        {
            throw new NotImplementedException();
        }

        public Drug Save(Drug obj)
        {
            throw new NotImplementedException();
        }

        public Drug Edit(Drug obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Drug obj)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll()
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
      private static DrugRepository Instance;
   
   }
}