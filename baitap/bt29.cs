using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace baitap
{
    class bt29
    {
        public static void Main()
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }
    }
}
