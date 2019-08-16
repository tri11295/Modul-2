using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt12
    {
        public static void Main()
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(number + " ");
            Console.Write(number + " ");
            Console.Write(number + " ");
            Console.WriteLine(number + " ");

            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);

            Console.WriteLine("{0} {0} {0} {0}", number);

            Console.WriteLine("{0}{0}{0}{0}", number);

            Console.Read();
        }
    }
}
