using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class max
    {
        public static void Main(string[] args)
        {
            int[] myArr = new int[] { 1, 2, 3, 4, 5, 6 };
         
            for(int i = 0; i < myArr.Length / 2; i++)
            {
                var temp = myArr[i];
                myArr[i] = myArr[myArr.Length - i - 1];
                myArr[myArr.Length - i - 1] = temp;
            }
            Console.WriteLine(string.Join(" ",myArr));
        }
    }
}
