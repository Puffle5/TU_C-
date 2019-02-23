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
{get {return currentUserRole;} private set {currentUserRole = value;}}
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
           
            currentUserRole = (UserRoles)addedUser.Role;


            if (emptyUserName) {this.errorMessage = "Missing username!"; return false;}
            if (emptyPassWord) {this.errorMessage = "Missing password!"; return false;}
            if (this.userName.Length < 5) {this.errorMessage = "Username too short!"; return false;}
            if (this.password.Length < 5) {this.errorMessage = "Password too short!"; return false;}
            User findUser = UserData.IsUserPassCorrect(this.userName, this.password);
            if (findUser == null) {return false;}
            addedUser.Username = findUser.Username;
            addedUser.Password = findUser.Password;
            addedUser.FakNum = findUser.FakNum;
            addedUser.Role = findUser.Role;

            return true;
        
        }
    }
}