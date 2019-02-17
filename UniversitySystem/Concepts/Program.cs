using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello!");
//StaticMembers.Reset();
Console.WriteLine(StaticMembers.Name);


Properties property = new Properties();
property.IQ = 5;
Console.WriteLine(property.IQ);

Console.ReadLine();
}}}
