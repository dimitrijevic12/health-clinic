/***********************************************************************
 * Module:  UserCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.UserCSVConverter
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.ComponentModel;

namespace Repository.Csv.Converter
{
   public class UserCSVConverter : ICSVConverter<RegisteredUser>
   {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public UserCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public RegisteredUser ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(_delimiter.ToCharArray());


            return new RegisteredUser();
        }

        public string ConvertEntityToCSVFormat(RegisteredUser entity)
        {
            return string.Join(_delimiter,
              entity.Id,
              entity.Name,
              entity.Surname,
              entity.Adress,
              entity.Username);
        }
    }
}