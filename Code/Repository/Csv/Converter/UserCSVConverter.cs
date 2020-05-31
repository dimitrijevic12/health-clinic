/***********************************************************************
 * Module:  UserCSVConverter.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.Csv.Converter.UserCSVConverter
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Repository.Csv.Converter
{
   public class UserCSVConverter : ICSVConverter<RegisteredUser>
   {
      private String Delimiter;

        public RegisteredUser ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(RegisteredUser entity)
        {
            throw new NotImplementedException();
        }
    }
}