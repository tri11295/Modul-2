using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt37
    {
        public static void Main()
        {
            string str = "PHP Tutorial";
            if (str.Substring(1, 2).Equals("HP"))
            {
                Console.WriteLine(str.Remove(1, 2));
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
