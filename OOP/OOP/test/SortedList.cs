using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test
{
    class SortedList
    {
        public static void Main()
        {
            SortedList<string,string> EmployeeList = new SortedList<string,string>();
            /*SortedList<string, List<string>> EmployeeList = new SortedList<string, List<string>>();*/
            EmployeeList.Add("Khoa", "co tuong");
            EmployeeList.Add("An", "co vua");
            EmployeeList.Add("Tri", "money");

      /*      // show all value

            Console.WriteLine("Show all value");
            foreach (var item in EmployeeList.Values)
            {
                Console.WriteLine(item);
            }
            // show all key

            Console.WriteLine("Show all key");
            foreach (var item in EmployeeList.Keys)
            {
                Console.WriteLine(item);
            }
            // show all values by key

            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("key : {0} , value : {1}", key, EmployeeList[key]);
            }
            // remove item by key

            EmployeeList.Remove("Khoa");
            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("key : {0} , value : {1}", key, EmployeeList[key]);
            }
            // remove item by key and return value

            string TriValue;
            EmployeeList.Remove("Tri", out TriValue);
            Console.WriteLine(TriValue);
            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("key : {0} , value : {1}", key, EmployeeList[key]);
            }*/

            // show all value by using enummator

            var enummerator = EmployeeList.GetEnumerator();
            while (enummerator.MoveNext())
            {
                Console.WriteLine("Key : {0} value : {1}", enummerator.Current.Key, enummerator.Current.Value);
            }

        }
       
        
        
    }
}
