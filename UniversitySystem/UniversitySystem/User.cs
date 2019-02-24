using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
class User
{
    public String Username;
    public String Password;
    public String FakNum;
    public Int32 Role;
    public DateTime Created;
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
