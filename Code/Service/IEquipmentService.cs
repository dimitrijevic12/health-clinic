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
        void addEquipment(int idE, int quant);
    }
}