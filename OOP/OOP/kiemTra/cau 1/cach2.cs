using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.kiemTra.cau_1
{
    public class cach2
    {
        static int n;
        static int m;
        static int[][] Array;
        public static void Main()
        {
            InitMenu();
            /* ShowMaxRow();*/
            /* Console.WriteLine("tong cac so chan {0}", TongCacSoChan(Array));*/
            XoaHang(Array);
        }

        public static void InitMenu()
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
        public static int Sum(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            return sum;
        }
        public static void ShowMaxRow()
        {
            var max = Sum(Array[0]);
            var flag = 0;
            for (int i = 0; i < Array.Length; i++)
            {           
                if (max < Sum(Array[i]))
                {
                    max = Sum(Array[i]);
                    flag = i;
                }                
            }
            Console.WriteLine($"Row has biggest sum is : {string.Join(",", Array[flag])}");
        }
        public static int TongCacSoChan(int[][] Array)
        {
            int Sum = 0;
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(Array[i][j] % 2 == 0)
                    {
                        Sum += Array[i][j];
                    }                    
                }
            }
            return Sum;
        } 
        public static void XoaHang(int[][] Array)
        {
            Console.WriteLine("Input k");
            int k = int.Parse(Console.ReadLine());
            if(k < Array.Length)
            {
                for (int i = k; i < n - 1; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Array[i][j] = Array[i + 1][j];
                    }
                }
                n--;
            }
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
        public static void XoaCot(int[][] Array)
        {

        }

    }
}
