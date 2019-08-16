using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt31
    {
        public static void Main()
        {
            int[] firstArray = { 1, 2, 3, 4 };
            int[] secondArray = { 5, 6, 7, 8 };
            Console.WriteLine(firstArray);
            Console.WriteLine(secondArray);
            for(int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine(firstArray[i] * secondArray[i] + " ");
            }

        }

    }
}
