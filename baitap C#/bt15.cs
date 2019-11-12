using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt15
    {
        private static string remove(string str, int n)
        {
            return str.Remove(n, 1);
        }
        public static void Main()
        {
            Console.WriteLine(remove("quangtri",1));
            Console.WriteLine(remove("Nguyen", 2));
            Console.Read();
        }

    }
}
