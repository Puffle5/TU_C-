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
        private String userName;
        private String password;
        private String errorMessage;

        public LoginValidation(String userName, String password) 
        {this.userName = userName; this.password = password;}


        public bool ValidateUserInput(User addedUser)
        {
            addedUser.Username = this.userName;
            addedUser.Password = this.password;
            currentUserRole = (UserRoles)addedUser.Role;
            return true;
        
        }
    }
}