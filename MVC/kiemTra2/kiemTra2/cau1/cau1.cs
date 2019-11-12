using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra2.cau1
{
    public class cau1
    {
        static int n;
        static int m;
        static int[][] Array;
        public static void Main()
        {
            CreateMatrix();
            Console.WriteLine("Max in Matrix {0}", FindMax());
            ShowMatrix();
        }
        public static void ShowArray()
        {
            Console.WriteLine("Array is : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void CreateMatrix()
        {
            Console.WriteLine("Input n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input m");
            m = int.Parse(Console.ReadLine());
            Array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Array[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Array [{0}] [{1}] =", i, j);
                    Array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            ShowArray();
        }
        public static int FindMax()
        {
            int Max = Array[0][0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   if(Max < Array[i][j])
                    {
                        Max = Array[i][j];
                    }
                }                
            }
            return Max;
        }
        public static void ShowMatrix()
        {
            Console.WriteLine("Array is : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(i >= j)
                    {
                        Console.Write(Array[i][j] + " ");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
