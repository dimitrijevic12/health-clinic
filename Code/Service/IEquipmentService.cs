/***********************************************************************
 * Module:  IEquipmentService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IEquipmentService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
    public interface IEquipmentService : IService<Equipment>
    {
        void addEquipment(string naziv, int quant);
        void deleteEquipment(int Id, int quant);

        String getNazivOpreme(int Id);

        int getIdOpreme(string naziv);
    }
}