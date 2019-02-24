using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
static class UserData
{

private static User[] testUsers;
public static User[] TestUsers
{
get {ResetUserData(); return testUsers;}
set {testUsers = value;}
}

private static void ResetUserData()
{
testUsers = new User[3];
testUsers[0] = new User("Puffle5", "12345", "121216007", 1);
testUsers[1] = new User("Johnson", "12321", "121216678", 4);
testUsers[2] = new User("Petur40", "1234567890", "121216123", 4);
for (int i = 0; i < TestUsers.Length; i++)
{TestUsers[i].Created = DateTime.Now; TestUsers[i].ExpirationDate = DateTime.MaxValue;}
//testUsers = new User[] {--"--};
}
public static User IsUserPassCorrect(String username, String password)
{
    //for (int i = 0; i < TestUsers.Length; i++) 
    foreach (User currentUser in TestUsers)
    {if (currentUser.Username == username && currentUser.Password == password) {return currentUser;}}

   return null;
}

public static void SetUserActiveTo(String username, DateTime newActivityDate) 
{
    for (int i = 0; i < TestUsers.Length; i++) 
    {
        if (TestUsers[i].Username == username) 
        {
          TestUsers[i].ExpirationDate = newActivityDate;
        }
    }

}
public static void AssignUserRole(String username, UserRoles newRole) 
{
    for (int i = 0; i < TestUsers.Length; i++) 
    {
        if (TestUsers[i].Username == username)
        {TestUsers[i].Role = (int)newRole; break;}
    
    }

}

}
}
