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
User Admin = UserData.TestUser;
Console.WriteLine("Enter username:");
String userName = Console.ReadLine();
Console.WriteLine("Enter password:");
String password = Console.ReadLine();
LoginValidation validation = new LoginValidation(userName, password);


if (validation.ValidateUserInput(Admin)) 
{Console.WriteLine(Admin.Username+", "+Admin.Password+", "+Admin.FakNum+", "+Admin.Role);}
Console.WriteLine(LoginValidation.CurrentUserRole);
Console.ReadLine();
}}}