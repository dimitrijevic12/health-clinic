using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.View.Converter
{
    class UserConverter : AbstractConverter
    {
        public static string ConvertUserToString(RegisteredUser user)
           => string.Join(" ", user);

        public static IList<string> ConvertUserListToStringList(IList<RegisteredUser> users)
            => ConvertEntityListToViewList(users, ConvertUserToString);
    }
}
