using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public class Event<T1,T2>
    {
        public T1 Id { get; set; }
        public T2 Name { get; set; }

        public T GetEvent<T>(T name)
        {
            return name;
        }
    }
}
