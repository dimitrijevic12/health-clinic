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
        void addEquipment(string naziv, int quant);
        void deleteEquipment(int Id, int quant);

        String getNazivOpreme(int Id);

        int getIdOpreme(String naziv);
    }
}