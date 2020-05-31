/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public class RenovationService : IRenovationService
   {
      public RenovationService GetInstance() { return null; }

        public Renovation ChangeDates(DateTime lastDate, Renovation renovation)
        {
            throw new NotImplementedException();
        }

        public Renovation DoPainting()
        {
            throw new NotImplementedException();
        }

        public Renovation DoMerge()
        {
            throw new NotImplementedException();
        }

        public Renovation DoSplit()
        {
            throw new NotImplementedException();
        }

        public Renovation DoChangeTypeOfRoom()
        {
            throw new NotImplementedException();
        }

        public Renovation Create(Renovation obj)
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

        public Repository.IRenovationRepository iRenovationRepository;
   
      private static RenovationService Instance;
   
   }
}