/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public class RenovationService : IRenovationService
   {
      public Repository.RenovationRepository renovationRepository;

        public Renovation Create(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public Renovation DoChangeTypeOfRoom()
        {
            throw new NotImplementedException();
        }

        public Renovation DoMerge()
        {
            throw new NotImplementedException();
        }

        public Renovation DoPainting()
        {
            throw new NotImplementedException();
        }

        public Renovation DoSplit()
        {
            throw new NotImplementedException();
        }

        public Renovation Edit(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public Renovation[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}