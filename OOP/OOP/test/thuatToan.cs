using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test
{
    public class thuatToan
    {
        public static void Main()
        {
            int[] MyArray = { 5, 9, 4, 3, 7, 11, 21, 16, 17, 13, 10 };
            Console.WriteLine(string.Join(",", MyArray));
            Console.WriteLine("------------------");

            SelectedSort(ref MyArray);
            Console.WriteLine(string.Join(",", MyArray));
            Console.WriteLine("------------------");

            InsertionSort(ref MyArray);
            Console.WriteLine(string.Join(",", MyArray));
            Console.WriteLine("------------------");

            BubbleSort(ref MyArray);
            Console.WriteLine(string.Join(",", MyArray));
            Console.WriteLine("------------------");

            Console.WriteLine("Index of value equals 9 = {0}", LinearSearch(MyArray, 9));
            Console.WriteLine("------------------");

            Console.WriteLine("Index of value equals 9 = {0}",BinarySearch(MyArray, 9));
        }
        
        public static void SelectedSort(ref int[] Array)
        {
            for(int i = 0; i <= Array.Length - 1; i++)
            {
                var min = Array[i];
                var pos = i;
                for(int j = i + 1; j < Array.Length; j++)
                {
                    if(Array[j] < min)
                    {
                        min = Array[j];
                        pos = j;
                    }
                }
                var temp = Array[pos];
                Array[pos] = Array[i];
                Array[i] = temp;
            }
        }

        public static void InsertionSort(ref int[] Array)
        {
            int pos;
            int valueInsert;
            for(int i = 1; i < Array.Length; i++)
            {
                pos = i;
                valueInsert = Array[i];

                while( pos > 0 && Array[pos - 1] > valueInsert)
                {
                    Array[pos] = Array[pos - 1];
                    pos = pos - 1;
                }
                Array[pos] = valueInsert;

            }
        }

        public static void BubbleSort(ref int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                for(int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        swap(ref Array[j], ref Array[j + 1]);
                    }
                }
            }            
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void QuickSort()
        {

        }

        public static int LinearSearch(int[] Array,int value)
        {
            int index = 0 ;
            for(int i = 0; i < Array.Length; i++ )
            {
                if(Array[i] == value)
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        public static int BinarySearch(int[] Array,int value)
        {
            int min = 0;
            int max = Array.Length - 1;

            while(min <= max)
            {
                int midPoint = (max + min) / 2;

                if (Array[midPoint] == value)
                {
                    return midPoint;
                }
                else if (Array[midPoint] > value)
                {
                    max = midPoint - 1;
                }
                else
                {
                    min = midPoint + 1;
                }
            }

            return - 1;
        }
    }
}
