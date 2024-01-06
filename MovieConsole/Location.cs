using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public abstract class Location
    {
        public void AddLocation()
        {
            //Console.Write("Enter number of locations:");
            string[] location = new string[3];
            string[] state = new string[3];
            for (int i = 0; i < location.Length; i++)
            {
                Console.Write("Enter state:");
                state[i] = Console.ReadLine();
                Console.Write("Enter location:");
                location[i] = Console.ReadLine();
            }
            Console.WriteLine("**************");
            for (int i = 0; i < location.Length; i++)
            {
                Console.WriteLine("State "+i+": " + state[i]);
                Console.WriteLine("Location " + i + ": " + location[i]);
            }
        }
        public void GetAll()
        {
        }
        public abstract void GetLocations();//method declaration
    }
}






