/***********************************************************************
 * Module:  Equipment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Equipment
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class Equipment
   {
      public static Equipment GetInstance()
      {
         // TODO: implement
         return null;
      }

      private static int brojac = 0;
      private int id;
      private TypeOfEquipment type;
      private int quantity;
        //private String Description;

        public Equipment(TypeOfEquipment tip, int quantity)
        {
          //  Id = brojac++;
            type = tip;
            Quantity = quantity;
        }

        public Equipment(int id, int quantity)
        {
            //  Id = brojac++;
            Id = id;
            Quantity = quantity;
        }

        public Equipment(int id, TypeOfEquipment tip, int quantity)
        {
            //  Id = brojac++;
            Id = id;
            type = tip;
            Quantity = quantity;
        }

        public TypeOfEquipment Type
        {
            get { return type; }   // get method
            set { type = value; }
        }

        public int Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; set => id = value; }

        //public int Type { get => type; set => type = value; }
    }
}