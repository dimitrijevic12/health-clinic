/***********************************************************************
 * Module:  IEquipmentController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IEquipmentController
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public interface IEquipmentController : IController<Equipment>
   {
        void addEquipment(string name, int quant);
        void deleteEquipment(long Id, int quant);

        String getNazivOpreme(long Id);

        long getIdOpreme(String name);
    }
}