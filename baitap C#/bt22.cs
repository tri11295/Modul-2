using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt22
    {
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
        public static void Main()
        {
            Console.WriteLine("Input n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(n));

        }
    }
}
