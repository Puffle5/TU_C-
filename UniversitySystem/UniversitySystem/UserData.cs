using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
static class UserData
{

private static User testUser;
public static User TestUser
{
get {ResetUserData(); return testUser;}
set {testUser = value;}
}

private static void ResetUserData()
{
testUser = new User("Puffle5", "12345", "121216007", 1);
}}}
