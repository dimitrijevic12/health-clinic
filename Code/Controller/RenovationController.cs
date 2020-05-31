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
      public RenovationController GetInstance() { return null; }
public List<Renovation> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Renovation obj)
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

        public Service.IRenovationService iRenovationService;
   
      private static RenovationController Instance;
   
   }
}