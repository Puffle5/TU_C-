﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
static class UserData
{

private static List<User> testUsers;

public static List<User> TestUsers
{
get {ResetUserData(); return testUsers;}
set {testUsers = value;}
}

private static void ResetUserData()
{
/*testUsers = new User[3];
testUsers[0] = new User("Puffle5", "12345", "121216007", 1);
testUsers[1] = new User("Johnson", "12321", "121216678", 4);
testUsers[2] = new User("Petur40", "1234567890", "121216123", 4);*/
    testUsers = new List<User>();
    testUsers.Add(new User("Puffle5", "12345", "121216007", 1));
    testUsers.Add(new User("Johnson", "12321", "121216678", 4));
    testUsers.Add(new User("Petur40", "1234567890", "121216123", 4));


for (int i = 0; i < testUsers.Count; i++)
{testUsers[i].Created = DateTime.Now; testUsers[i].ExpirationDate = DateTime.MaxValue;}
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
    for (int i = 0; i < TestUsers.Count; i++) 
    {
        if (TestUsers[i].Username == username) 
        {
          TestUsers[i].ExpirationDate = newActivityDate;
        }
    }
    Logger.LogActivity("Change of "+username+"'s activity");
}
public static void AssignUserRole(String username, UserRoles newRole) 
{
    for (int i = 0; i < TestUsers.Count; i++) 
    {
        if (TestUsers[i].Username == username)
        {TestUsers[i].Role = (int)newRole; break;}
    
    }
    Logger.LogActivity("Change of " + username + "'s role");
}

}
}
