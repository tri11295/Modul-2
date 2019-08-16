using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt28
    {
        public static void Main()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            string result = "";
            string[] words = line.Split(new [] {" "}, StringSplitOptions.None);
            for(int i = words.Length -1 ; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
