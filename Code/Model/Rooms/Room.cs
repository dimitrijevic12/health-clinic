/***********************************************************************
 * Module:  Room.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Room
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Model.Rooms
{
   public class Room
   {
       //bio private ili protected (ne secam se) long Id, ali sam ga obrisao zbog dole gettera i settera
      public InventoryEquip[] inventoryEquip;

        protected List<Equipment> equipments;
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

        public List<Equipment> Equipments
        {
            get { return equipments; }
            set { equipments = value; }
        }


        public Room(long id)
        {
            this.Id = id;
            Equipments = new List<Equipment>();
        }

        public Room(long id, TypeOfRoom tip)
        {
            this.Id = id;
            this.tipSobe = tip;
            Equipments = new List<Equipment>();
        }

        
    }

}