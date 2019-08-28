using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test
{
    class List
    {
        public static void Main()
        {
            List<Dictionary<int, string>> CB = new List<Dictionary<int, string>>();
            var to1 = new Dictionary<int, string>();
            to1.Add(1, "Khoa Nguyen");
            to1.Add(2, "Bao Nguyen");
            CB.Add(to1);
            var to2 = new Dictionary<int, string>();
            to2.Add(3, "Huy Nguyen");
            to2.Add(4, "Tri Nguyen");
            CB.Add(to2);
            foreach(var to in CB)
            {
                
                foreach(var member in to)
                {
                    Console.WriteLine("Id: {0}, Name: {1}",member.Key,member.Value);
                }
              
            }
        }
    }
}
