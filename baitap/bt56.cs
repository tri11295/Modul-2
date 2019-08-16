using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt56
    {
        public static bool checkPalindrome(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(str);
        }
        public static void Main()
        {
            Console.WriteLine("Input String");
            string str = (Console.ReadLine());
            Console.WriteLine(checkPalindrome(str));
        }
    }
}
