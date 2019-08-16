using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt20
    {
        public static int result(int x, int y)
        {
            if(x > y)
            {
                return (x - y) * 3;
            }
            else
            {
                return y - x;
            }
        }
        public static void Main()
        {
            Console.WriteLine(result(5, 6));
            Console.WriteLine(result(6, 5));
        }
    }
}
