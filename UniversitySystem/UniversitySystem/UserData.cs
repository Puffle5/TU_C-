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
testUsers[0] = new User("Puffle5", "12345", "121216007", 0);
testUsers[1] = new User("John", "12321", "121216678", 0);
testUsers[2] = new User("Petur40", "1234567890", "121216123", 0);
//testUsers = new User[] {--"--};
}}}
