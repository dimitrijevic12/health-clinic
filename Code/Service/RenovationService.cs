/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class RenovationService : IRenovationService
   {
        private readonly IRenovationRepository iRenovationRepository = RenovationRepository.Instance;


        private static RenovationService instance = null;

        public static RenovationService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenovationService();
                }
                return instance;
            }
        }

        private RenovationService()
        {
        }

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
            var renovation = iRenovationRepository.Save(obj);

            return renovation;
        }

        public Renovation Edit(Renovation obj)
        {
            var renovation = iRenovationRepository.Edit(obj);
            return renovation;
        }

        public bool Delete(Renovation obj)
        {
            bool Correct = iRenovationRepository.Delete(obj);
            return Correct;
        }

        public List<Renovation> GetAll()
        {
            return iRenovationRepository.GetAll();
        }

        
   }
}