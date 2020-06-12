/***********************************************************************
 * Module:  Room.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Room
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class Room
   {
<<<<<<< HEAD
      public InventoryEquip[] inventoryEquip;
   
      protected long Id;
   
   }
=======
        public InventoryEquip[] inventoryEquip;

        protected long _id;
        protected TypeOfRoom tipSobe;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public TypeOfRoom tip
        {
            get { return tipSobe; }
            set { tipSobe = value; }
        }

        public Room(long id)
        {
            Id = id;
        }
        public Room(long id, TypeOfRoom tip)
        {
            this.Id = id;
            this.tipSobe = tip;
        }
    }
>>>>>>> master
}