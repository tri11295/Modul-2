using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class baitap1
    {
        public static void Main()
        {
            int number;
            Console.WriteLine("Input number");
            number = int.Parse(Console.ReadLine());
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(number + "*" + i + "=" + number * i);
            }
            Console.Read();
        }
    }
}
