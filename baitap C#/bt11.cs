using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class BT11
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("Input age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
            Console.Read();
        }
    }
}
