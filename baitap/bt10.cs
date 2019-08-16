using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class BT10
    {
        public static void Main()
        {
            int x, y, z;
            Console.WriteLine("Input x = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input y = ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input z = ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("Result of specified numbers {0},{1},{2}, (x+y)*z = {3}, x*y+y*z = {4}", x, y, z, (x + y) * z, x * y + y * z);
            Console.Read();
        }
    }
}
