using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//Non-Generic
//Non-generic collection
//ArrayList,Stack,Queue,SortedList
namespace MovieConsole
{
    public class Transactions
    {
        public void AddTransaction()
        {
            #region arraylist
            ArrayList list = new ArrayList();
            list.Add(101);//T_Id
            list.Add("Netbanking");//T_Type
            list.Add("Success");//T_Status
            list.Add(DateTime.Now);//T_Date

            //how to access arraylist items
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Remove(101);//item
            list.RemoveAt(2);//index
            //how to modify list value
            list[0] = "UPI";
            #endregion

            #region stack
            Stack s= new Stack();
            s.Push(101); //[3] add item push() method
            s.Push("Netbanking");//[2]
            s.Push("Success"); //[1]
            s.Push(DateTime.Now); //[0]
            Console.WriteLine(s.Pop());//how to fetch item pop()
            //how to access stack items without pop() method
            foreach (var item in s)
            {
                
                Console.WriteLine(item);
            }

            #endregion

            #region 
            #endregion
        }

        //public bool CheckValues(int v1,int v2)
        //{
        //    return v1 == v2;
        //}
        //public bool CheckValues(string v1, string v2)
        //{
        //    return v1 == v2;
        //}
        //public bool CheckValues(double v1, double v2)
        //{
        //    return v1 == v2;
        //}
        public bool CheckValues<T>(T t1,T t2)
        {
            Console.WriteLine("T1 value:" + t1);
            Console.WriteLine("T2 value:" + t2);
            return t1.Equals(t2); //t1==t2
        }
    }
}
