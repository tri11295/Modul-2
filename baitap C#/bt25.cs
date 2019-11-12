using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class test
    {
        public static void Main()
        {
            Console.WriteLine("Odd number form 1 to 99");
            for(int i = 1; i <= 99; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
