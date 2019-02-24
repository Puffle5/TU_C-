using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
class Program
{
    public static void displayError(String errorMessage) 
    {
        Console.WriteLine("!!! "+errorMessage+" !!!");
    }
 static void Main(string[] args)
{
//User Admin = UserData.TestUsers;
Console.WriteLine("Enter username:");
String userName = Console.ReadLine();
Console.WriteLine("Enter password:");
String password = Console.ReadLine();
LoginValidation.ActionOnError actionOnError = new LoginValidation.ActionOnError(displayError);

LoginValidation validation = new LoginValidation(userName, password, actionOnError);
User user = new User();

if (validation.ValidateUserInput(user))
{ 
Console.WriteLine(user.Username + ", " + user.Password + ", " + user.FakNum + ", " + user.Role);
switch (user.Role) 
{
case 0: Console.WriteLine("Welcome, ANONYMOUS!"); break;
case 1: Console.WriteLine("Welcome, ADMIN!");
    String adminOption = "-1";
    while (adminOption != "0") 
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("0: Exit");
        Console.WriteLine("1: Change User Role");
        Console.WriteLine("2: Change User Activity");
        adminOption = Console.ReadLine();
        
        switch (adminOption) 
        {
            case "1": changeUserRole(); break;
            case "2": changeUserActivity(); break;
        
      }
    
    }
    
break;
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
}
 public static void changeUserRole() 
 {
     Console.WriteLine("Enter username:");
     String username = Console.ReadLine();
     Console.WriteLine("Enter new role:");
     int newRole = int.Parse(Console.ReadLine());
     UserRoles currentRole = (UserRoles)newRole;
     UserData.AssignUserRole(username, currentRole);
 }

 public static void changeUserActivity() 
 
{
    Console.WriteLine("Enter username:");
    String username = Console.ReadLine();
    Console.WriteLine("Enter Year:");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Month:");
    int month = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Day:");
    int day = int.Parse(Console.ReadLine());
    DateTime date = new DateTime(year, month, day);
    UserData.SetUserActiveTo(username, date);
 
 
}


}}