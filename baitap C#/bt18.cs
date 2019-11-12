using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt18
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("Input x ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y ");
            y = Convert.ToInt32(Console.ReadLine());
            if(x*y < 0)
            {
                Console.WriteLine("Check if one is negative and one is positive: True");
            }
            else
            {
                Console.WriteLine("Check if one is negative and one is positive: False");
            }
        }
    }
}
