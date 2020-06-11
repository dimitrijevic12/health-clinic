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
   
      private Drug Instance;
      private int Id;
      private String Name;
      private String Description;
      private Boolean Validation;
      private int Quantity;
   
   }
}