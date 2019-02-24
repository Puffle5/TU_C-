using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
class User
{
    public String Username {get; set;}
    public String Password {get; set;}
    public String FakNum {get; set;}
    public Int32 Role {get; set;}
    public DateTime Created {get; set;}
    public DateTime ExpirationDate {get; set;}
    public User() { }
    public User(String Username, String Password, String FakNum, Int32 Role) 
    {
        this.Username = Username;
        this.Password = Password;
        this.FakNum = FakNum;
        this.Role = Role;
 

    }
}
}
