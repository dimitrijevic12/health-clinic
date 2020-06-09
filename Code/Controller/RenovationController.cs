/***********************************************************************
 * Module:  RenovationController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Controller.RenovationController
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RenovationController : IRenovationController
   {

        public Service.IRenovationService iRenovationService;

        private static RenovationController Instance;

        public RenovationController GetInstance() { return null; }
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

   
   }
}