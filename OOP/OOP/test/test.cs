using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test
{
    class test
    {
        public static void Main()
        {
            Console.WriteLine("Input so phan tu");
            int n;
            //do
            //{
            //    int.TryParse(Console.ReadLine(), out n);
            //}
            //while (n <= 0);         
            //int[] Array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    var number = 0;
            //    var t = false;
            //    do
            //    {
            //        Console.WriteLine("Nhap phan tu thu {0} ", i + 1);
            //        if (int.TryParse(Console.ReadLine(), out number))
            //        {
            //            Array[i] = number;
            //            t = true;
            //        }
            //    }
            //    while (!t);
            //}

            //Console.WriteLine(string.Join(",", Array));

            int i = 1;
            while (i < 5)
            {
                if (i % 3 != 0)
                {
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Hello");
                    i++;
                }
               
            }
        }
    }
}
