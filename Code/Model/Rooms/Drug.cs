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
      private long id;
      private String name;
     
      private String Description;
      private Boolean validation;
      private int quantity;
        public static int brojac = 100;

        public Drug(string name, int quantity)
        {
          
            Name = name;
            Quantity = quantity;
            Validation = false;
        }
        public Drug(long id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Validation = false;
        }

        public Drug(string name)
        {
            Name = name;
            Validation = false;
          
        }

        public Drug(Ingredients ingredients, string name, string description, bool validation, int quantity)
        {
            this.ingredients = ingredients;
            this.name = name;
            Description = description;
            Validation = false;
            this.quantity = quantity;
          
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public long Id { get => id; set => id = value; }

        public bool Validation
        {
            get { return validation; }   // get method
            set { validation = value; }
        }
    }
}