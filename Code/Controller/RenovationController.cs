/***********************************************************************
 * Module:  RenovationController.cs
 * Author:  user
 * Purpose: Definition of the Class Controller.RenovationController
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public class RenovationController : IRenovationController
   {
      public Service.RenovationService renovationService;

        public Renovation Create(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public Renovation Edit(Renovation obj)
        {
            throw new NotImplementedException();
        }

        public Renovation GetAll()
        {
            throw new NotImplementedException();
        }
    }
}