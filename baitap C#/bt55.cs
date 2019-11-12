using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt55
    {
        public static int array_adjacent_elements_product(int[] array)
        {
            int maxAdjacent = 0;
            for (int i = 0;i < array.Length - 1; i++)
            {
                if(array[i] * array[i + 1] > maxAdjacent)
                {
                    maxAdjacent = array[i] * array[i + 1];
                }
            }
            return maxAdjacent;
        }
        public static void Main()
        {
            Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
        }
    }
}
