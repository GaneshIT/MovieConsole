using MovieConsole;
using System;
using System.Collections;

ArrayList eventList = new ArrayList();//count 0
Events eventsObj=new Events(1,"ABC","Sports",DateTime.Now,10);
eventList.Add(eventsObj);//eventsObj.Id,eventsObj.Name,eventsObj.
//eventsObj.AddEvent(eventsObj);

eventsObj = new Events(2, "XYZ", "Sports", DateTime.Now, 20);
//eventsObj.AddEvent(eventsObj);
eventList.Add(eventsObj);//eventsObj.Id,eventsO
eventsObj = new Events(3, "MNO", "Bday", DateTime.Now, 10);
//eventsObj.AddEvent(eventsObj);
eventList.Add(eventsObj);

eventsObj = new Events(4, "HJK", "Sports", DateTime.Now, 40);
//eventsObj.AddEvent(eventsObj);
eventList.Add(eventsObj);//eventsObj.Id,eventsO
//Count 4
ArrayList output= eventsObj.GetEventsByType("Sports", eventList);
foreach (Events item in output)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Name);
    Console.WriteLine(item.EventDate);
    Console.WriteLine(item.Type);
    Console.WriteLine(item.Count);
}
//Event<int,string> eventObj=new Event<int, string>();//string generic
//string output=eventObj.GetEvent<string>("Sports");
//Console.WriteLine(output);

////Event<int> eventObj1 = new Event<int>();//int generic
////int output1 = eventObj1.GetEvent<int>(101);
////Console.WriteLine(output1);

//Transactions obj=new Transactions();
////obj.AddTransaction();
//bool result1=obj.CheckValues<string>("v1", "v2");
//Console.WriteLine(result1);
//bool result2 = obj.CheckValues<int>(100, 200);
//Console.WriteLine(result2);
//bool result3 = obj.CheckValues<string>("10", "10");
//Console.WriteLine(result3);
//bool result4 = obj.CheckValues<double>(10.20, 30.40);
//Console.WriteLine(result4);


//function 1 logic


//funciotn 2 logic

//int[] array = new int[8] { 5, 3, 6, 2, 1, 4, 8, 7 };
//int large = 0, small = 0, mid = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    if (large < array[i] && mid <= large)
//    {
//        small = mid;
//        mid = large;
//        large = array[i];
//    }
//    else if (mid < array[i] && small <= mid)
//    {
//        small = mid;
//        mid = array[i];
//    }
//    else if (small <= array[i])
//    {
//        small = array[i];
//    }
//}
//Console.WriteLine(mid);