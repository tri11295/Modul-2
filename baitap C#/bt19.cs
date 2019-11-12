using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt19
    {
        public static int trippleSum(int x,int y)
        {
            if(x == y)
            {
                return (x + y) * 3;
            }
            else
            {
                return x + y;
            }
        }
        public static void Main()
        {
            Console.WriteLine(trippleSum(2,2));
            Console.WriteLine(trippleSum(5,6));
        }
    }
}
