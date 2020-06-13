/***********************************************************************
 * Module:  Drug.cs
 * Author:  User
 * Purpose: Definition of the Class Rooms.Drug
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class Drug
   {
      public Drug GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Ingredients ingredients;
      private int id;
      private String name;
      private String Description;
      private Boolean Validation;
      private int quantity;
        private static int brojac = 0;

        public Drug(string name, int quantity)
        {
            id = brojac++;
            Name = name;
            Quantity = quantity;
        }

        public Drug(string name)
        {
            Name = name;
           // id = brojac++;
        }

        public Drug(Ingredients ingredients, string name, string description, bool validation, int quantity)
        {
            this.ingredients = ingredients;
            this.name = name;
            Description = description;
            Validation = validation;
            this.quantity = quantity;
          //  id = brojac++;
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; set => id = value; }
    }
}