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

        public Drug(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public Drug(string name)
        {
            Name = name;
        }

        public Drug(Ingredients ingredients, string name, string description, bool validation, int quantity)
        {
            this.ingredients = ingredients;
            this.name = name;
            Description = description;
            Validation = validation;
            this.quantity = quantity;
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; set => id = value; }
    }
}