/***********************************************************************
 * Module:  RenovationController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Controller.RenovationController
 ***********************************************************************/

using Model.Rooms;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RenovationController : IRenovationController
   {

        public Service.IRenovationService iRenovationService;

        private static RenovationController Instance;

        public RenovationController GetInstance() { return null; }

        public RenovationController(IRenovationService service)
        {
            iRenovationService = service;
        }
        public List<Renovation> GetAll()
        {
            return iRenovationService.GetAll();
        }

        public bool Delete(Renovation obj)
        {
            return iRenovationService.Delete(obj);
        }

        public Renovation Create(Renovation obj)
        {
            return iRenovationService.Create(obj);
        }

        public Renovation Edit(Renovation obj)
        {
            return iRenovationService.Edit(obj);
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
    }
}