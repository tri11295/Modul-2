using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.kiemTra.cau_1
{
    public class cau1
    {
        public static int n;
        public static int m;
        public static int[,] Array;        

        public static int[] SumArrayRow ; 

        public static void InitMatrix()
        {
            Console.WriteLine("Input n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input m");
            m = Convert.ToInt32(Console.ReadLine());
            Array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input value of row {0}", i);
                for (int j = 0; j < m; j++)
                {
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Mang vua nhap la : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[] Sum(int[,] Array)
        {
            SumArrayRow = new int[n];            
            for(int i = 0; i < Array.GetLength(0); i++)
            {
                SumArrayRow[i] = 0;
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    SumArrayRow[i] += Array[i, j];
                }
            }
            return SumArrayRow;
        }

        public static void ShowMaxRow(int[,] Array)
        {
            int max = SumArrayRow[0];
            int row = 0;
            for (int i = 0; i < SumArrayRow.Length; i++)
            {
                if(max < SumArrayRow[i])
                {
                    max = SumArrayRow[i];
                    row = i;
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(Array[row, i] + " ");
            }
        }
        public static void Main()
        {
            InitMatrix();
            Console.WriteLine("Sum of Row");
            Console.WriteLine(string.Join(",", Sum(Array)));            
            ShowMaxRow(Array);
        }
    }
}
