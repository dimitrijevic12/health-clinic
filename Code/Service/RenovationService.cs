/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Service
{
   public class RenovationService : IRenovationService
   {
        public Repository.IRenovationRepository iRenovationRepository;
        

        private static RenovationService Instance;
        

        public RenovationService GetInstance() { return null; }

        public Renovation ChangeDates(DateTime lastDate, Renovation renovation)
        {          
            if(lastDate != null)
            {
                double traje = (renovation.endDate - renovation.startDate).TotalDays;
                renovation.startDate = lastDate.AddDays(1); ;
                renovation.endDate = renovation.endDate.AddDays(traje);
            }
            return renovation;
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