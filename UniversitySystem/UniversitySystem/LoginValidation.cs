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

            Boolean emptyUserName = this.userName.Equals(String.Empty); 
            Boolean emptyPassWord = this.password.Equals(String.Empty);
            addedUser.Username = this.userName;
            addedUser.Password = this.password;
            currentUserRole = (UserRoles)addedUser.Role;
            if (emptyUserName) {this.errorMessage = "Missing username!"; return false;}
            if (emptyPassWord) {this.errorMessage = "Missing password!"; return false;}

            return true;
        
        }
    }
}