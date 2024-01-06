using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieConsole
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public User() { }
        public User(int id,string name,string email) 
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public void AddUser()
        {
            FileStream fs = null;
            if (File.Exists("user.txt"))
                fs = new FileStream("user.txt", FileMode.Append, FileAccess.Write);
            else
                fs = new FileStream("user.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            //write data into file
            sw.WriteLine("Id:" + Id);
            sw.WriteLine("Name:" + Name);
            sw.WriteLine("Email:" + Email);
            sw.Close();//closing write operation
            fs.Close();//closing file operation
        }
        public void GetAll()
        {
            FileStream fs = new FileStream("user.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
               var re= line.Split(':');
                re = null;
                Console.WriteLine(sr.ReadLine());
            }
        }
        public string GetEmail(int id)
        {
            return Email;
        }
        public string GetValue(out int i)//M001, 10
        {
            i = 10;
            i = i + 10;//20
            return i.ToString();//20
        }

    }
}
