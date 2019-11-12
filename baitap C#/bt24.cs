using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt24
    {
        public static void Main()
        {
            string str = "Write a C# Sharp Program to display the following pattern using the alphabet";
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string longestWord = "";
            int maxlength = 0;
            foreach(string s in words)
            {
                if(s.Length > maxlength)
                {
                    longestWord = s;
                    maxlength = s.Length;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
