using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt32
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            
        }
    }
}
