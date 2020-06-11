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
       //bio private ili protected (ne secam se) long Id, ali sam ga obrisao zbog dole gettera i settera
      public InventoryEquip[] inventoryEquip;
   
      

        protected long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Room(long id)
        {
            this.Id = id;
        }
    }

}