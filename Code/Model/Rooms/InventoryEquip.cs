/***********************************************************************
 * Module:  InventoryEquipE/o.cs
 * Author:  User
 * Purpose: Definition of the Class Rooms.InventoryEquipE/o
 ***********************************************************************/

using System;
using System.Windows.Navigation;

namespace Model.Rooms
{
   public class InventoryEquip
   {
      private Room room;
      private Equipment equipment;
      private long id;
      private int Quantity;
   
        public long Id { get { return id; } set { id = value; } }
       
    }
}