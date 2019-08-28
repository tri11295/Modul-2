using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test
{
    public class Fibonancy
    {
        public static void Main()
        {
          /*  Console.WriteLine("Input n =");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, GiaiThua(n));*/

            int[] Arr = { 6, 8, 5, 4, 5, 13, 7, 11, 9 };
            /* Console.WriteLine("Sum Array = {0}", SumArr(Arr, Arr.Length));*/

            Console.WriteLine(string.Join(",", Arr));
            SelectionSort( ref Arr);
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(",", Arr));
        }

        public static long GiaiThua(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            return n * GiaiThua(n - 1);
        }

        public static long SumArr(int[] NameArr,int LengthArr)
        {
            if(LengthArr == 0)
            {
                return 0;
            }
            return SumArr(NameArr, LengthArr - 1) + NameArr[LengthArr - 1];
        }

        public static void SelectionSort (ref int[] A)
        {
            for(int i = 0; i <= A.Length - 1; i++)
            {
                var min = A[i];
                var pos = i;
                for(int j = i +1; j < A.Length; j++)
                {
                    if(A[j] < min)
                    {
                        min = A[j];
                        pos = j;
                    }
                }
                var temp = A[i];
                A[i] = A[pos];
                A[pos] = temp;
            }
        }
    }
}
