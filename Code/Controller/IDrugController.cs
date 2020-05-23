/***********************************************************************
 * Module:  IDrugController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IDrugController
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public interface IDrugController : IController<Drug>
   {
      Boolean ValidateDrugs(Model.Rooms.Drug drug);
   }
}