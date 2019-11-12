using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt33
    {
        public static void Main()
        {
            int number;
            Console.WriteLine("Input your number");
            number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
            {
                Console.WriteLine(number % 3 == 0 || number % 7 == 0);
                Console.Read();
            }
        }
    }
}
