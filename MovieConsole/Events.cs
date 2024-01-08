using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public class Events
    {
        //  public static ArrayList events = new ArrayList();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime EventDate { get; set; }
        public int Count { get; set; }
        public Events(int id, string name, string type, DateTime eDate, int count)
        {
            Id = id;
            Name = name;
            Type = type;
            EventDate = eDate;
            Count = count;
        }
        public void AddEvent(Events o)
        {
            //events.Add(o);//o.Id,o.Name, o.Type,o
        }
        public ArrayList GetEventsByType(string type, ArrayList inputList)
        {
            ArrayList outputList = new ArrayList();
            foreach (Events eventObj in inputList)
            {
                if(eventObj.Type == type)
                {
                    outputList.Add(eventObj);
                }
            }
            return outputList;
        }

    }
}
