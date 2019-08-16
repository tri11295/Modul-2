using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt14
    {
        public static void Main()
        {
            int celsius;
            Console.WriteLine("Input celsius ");
            celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.Read();
        }
    }
}
