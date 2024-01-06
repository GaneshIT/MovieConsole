using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public class Account
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Account() { }
        public Account(string name) 
        {
            Name = name;
        }
        public Account(string name, int age) 
        {
            Age = age;
            Name = name;
        }
        public void GetAll(int age,string name)
        {
            Console.WriteLine(age + "," + name);
        }
    }
}
