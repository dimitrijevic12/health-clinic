/***********************************************************************
 * Module:  IDrugController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IDrugController
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Controller
{
   public interface IDrugController : IController<Drug>
    {
      List<Drug> GetAllDrugs();
        void addDrug(String naziv, int quant);
    }
}