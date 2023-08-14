using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem_EF.Dal.Models.Identity
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }

        public const string default_username = "user";
        public const string default_password = "password";
        public const string default_email = "useremail@gmail.com";
        public const Roles default_role = Roles.User;
    }
}
