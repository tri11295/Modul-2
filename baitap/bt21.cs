using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt21
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("Input x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || x + y == 20);
        }
    }
}
