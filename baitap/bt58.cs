using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt58
    {
        public static int consecutive_array(int[] array)
        {
            Array.Sort(array);
            int count = 0;
            for(int i = 0;i < array.Length - 1; i++)
            {
                count += array[i + 1] - array[i] - 1; 
            }
            return count;
        }
        public static void Main()
        {
            Console.WriteLine(consecutive_array(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(consecutive_array(new int[] { 0, 10 }));
        }
    }
}
