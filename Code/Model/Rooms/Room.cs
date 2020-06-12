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

<<<<<<< HEAD


        protected TypeOfRoom tipSobe;
        protected long _id;
=======
        protected long _id;
        protected TypeOfRoom tipSobe;
>>>>>>> master
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
<<<<<<< HEAD

        public Room(long id)
        {
            this.Id = id;
        }

        public Room(long id, TypeOfRoom tip)
        {
            this.Id = id;
            this.tipSobe = tip;
        }
=======
>>>>>>> master

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

}