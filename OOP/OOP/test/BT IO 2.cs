using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP.test
{
    class BT_IO_2
    {
        public static FileStream file2 = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\ArrInput.txt", FileMode.Create);
        public static FileStream file3 = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\ArrOutput.txt", FileMode.Create);
        public static void Main()
        {
            Console.WriteLine("Input n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] Array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input value of row {0}", i);
                for (int j = 0; j < n; j++)
                {
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Mang vua nhap la : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }

            writeArray(n, Array);
        }

        public static void writeArray(int n, int[,] Array)
        {
            using (StreamWriter writer = new StreamWriter(file2))
            {
                writer.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        writer.Write(Array[i, j] + " ");
                    }
                    writer.WriteLine();
                }
            }
        }

        public static void ReadAndWriteArray(int n,int[,] Array)
        {           
            using (StreamReader reader = new StreamReader(file2))
            {
                int sum1 = 0;
                for (int i = 0; i < n; i++)
                {
                    reader.ReadLine();
                    continue;
                }
            }
           
        }
    }
}
