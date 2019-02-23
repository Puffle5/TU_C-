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
User Admin = UserData.TestUsers;
Console.WriteLine("Enter username:");
String userName = Console.ReadLine();
Console.WriteLine("Enter password:");
String password = Console.ReadLine();
LoginValidation validation = new LoginValidation(userName, password);
User user = new User();

if (validation.ValidateUserInput(user))
{ Console.WriteLine(user.Username + ", " + user.Password + ", " + user.FakNum + ", " + user.Role); }
Console.WriteLine(LoginValidation.CurrentUserRole);
Console.ReadLine();
}}}