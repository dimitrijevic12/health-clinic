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
        void addEquipment(string name, int quant);
        void deleteEquipment(long Id, int quant);

        String getNazivOpreme(long Id);

        long getIdOpreme(string name);
    }
}