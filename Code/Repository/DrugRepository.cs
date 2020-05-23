/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public class DrugRepository : IDrugRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Drug obj)
        {
            throw new NotImplementedException();
        }

        public Drug Edit(Drug obj)
        {
            throw new NotImplementedException();
        }

        public Drug[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Drug GetDrug(Drug drug)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Drug Save(Drug obj)
        {
            throw new NotImplementedException();
        }
    }
}