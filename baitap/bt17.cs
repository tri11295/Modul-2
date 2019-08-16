using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt17
    {
        public static string add(string str)
        {
            if (str.Length > 0)
            {
                string s = str.Substring(0, 1);
                return s + str + s;
            }
            else
                return str;
        }
        public static void Main()
        {
            Console.WriteLine(add("QuangTri"));
            Console.WriteLine(add("Nguyen"));

            Console.Read();
        }
    }
}
