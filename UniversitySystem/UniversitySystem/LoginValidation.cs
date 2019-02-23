using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
    class LoginValidation
    {
        public static UserRoles CurrentUserRole
        {
            get { return currentUserRole; }
            private set { currentUserRole = value; }
        }
        private static UserRoles currentUserRole;
        private static String userName;
        private static String password;
        private static String errorMessage;
        public bool ValidateUserInput()
        {return true;}
    }
}
