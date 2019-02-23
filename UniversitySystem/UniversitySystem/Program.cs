using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
class Program
{
 static void Main(string[] args)
{
//User Admin = UserData.TestUsers;
Console.WriteLine("Enter username:");
String userName = Console.ReadLine();
Console.WriteLine("Enter password:");
String password = Console.ReadLine();
LoginValidation validation = new LoginValidation(userName, password);
User user = new User();

if (validation.ValidateUserInput(user))
{ 
Console.WriteLine(user.Username + ", " + user.Password + ", " + user.FakNum + ", " + user.Role);
switch (user.Role) 
{
    case 0: Console.WriteLine("Welcome, ANONYMOUS!"); break;
    case 1: Console.WriteLine("Welcome, ADMIN!"); break;
    case 2: Console.WriteLine("Welcome, INSPECTOR!"); break;
    case 3: Console.WriteLine("Welcome, PROFESSOR!"); break;
    case 4: Console.WriteLine("Welcome, STUDENT!"); break;
    
}
}

else 
{
    Console.WriteLine("Validation Failed!");
    Console.WriteLine(LoginValidation.CurrentUserRole); 
}

Console.ReadLine();
}}}