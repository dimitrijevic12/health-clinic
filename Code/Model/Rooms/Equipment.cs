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

        private int id;
        Random rnd = new Random();
        private TypeOfEquipment type;
        private String naziv;
        private int quantity;

        public Equipment(TypeOfEquipment tip, int quantity)
        {
            type = tip;
            Quantity = quantity;
        }
        public Equipment(String naziv, int quantity)
        {
            Id = rnd.Next(1, 10000);
            Naziv = naziv;
            Quantity = quantity;
        }
        public Equipment(int id, String naziv, int quantity)
        {
            Id = id;
            Naziv = naziv;
            Quantity = quantity;
        }

        public Equipment(int id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }

        public Equipment(int id, TypeOfEquipment tip, int quantity)
        {
            Id = id;
            type = tip;
            Quantity = quantity;
        }

        public TypeOfEquipment Type
        {
            get { return type; }   // get method
            set { type = value; }

        }
        public String Naziv
        {
            get { return naziv; }   // get method
            set { naziv = value; }
        }

        public int Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; set => id = value; }
        public string Ispisi()
        {
            return "Id : " + id + " " + " Naziv: " + naziv + " Kolicina: " + quantity;
        }

    }
}