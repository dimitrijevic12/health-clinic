/***********************************************************************
 * Module:  RegisteredUser.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.RegisteredUser
 ***********************************************************************/

using System;

namespace Model.SystemUsers
{
   public class RegisteredUser
   {
        private Adress adress;

        private String username;
        private String password;
        private String name;
        private String surname;
        private long id;

        public RegisteredUser(Adress adress, string username, string password, string name, string surname, long id)
        {
            Adress = adress;
            Adress = adress;
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            Id = id;
        }

        public RegisteredUser(long id, string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = id;
        }

        public RegisteredUser()
        {
        }

        public Adress Adress { get => adress; set => adress = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long Id { get => id; set => id = value; }
    }
}