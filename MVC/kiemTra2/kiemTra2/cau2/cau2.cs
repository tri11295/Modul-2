using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra2.cau2
{
    public class cau2
    {
        public static int[] Array;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Create Array");
                Console.WriteLine("2. Is Symmetry Array");
                Console.WriteLine("3. Sort Array");
                Console.WriteLine("4. Find array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please select an opition");
                Console.WriteLine("Opition: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 5 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine(" Create Array ................");
                        CreatArray();
                        Show(Array);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Is Symmetry Array ................");
                        if (IsSymmetryArray(Array))
                        {
                            Console.WriteLine("Array is Symmetry Array");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Array is Not Symmetry Array");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" Sort Array ................");
                        BubbleSort(Array);
                        Show(Array);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Find array ................");
                        Console.WriteLine("Input number ");
                        int n;
                        do
                        {
                            int.TryParse(Console.ReadLine(), out n);                            
                        }
                        while (n <= 0);
                        if (Find(Array, n) > -1)
                        {
                            Console.WriteLine("Number position to search for: {0}", string.Join(",", Find(Array, n)));                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not found");                          
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Exit ................");
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void CreatArray()
        {
            Console.WriteLine("Input size of Array: ");
            int n;
            do
            {
                int.TryParse(Console.ReadLine(), out n);
            }
            while (n <= 0);
            Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                var number = 0;
                var kt = false;
                do
                {
                    Console.WriteLine("Input array{0}: ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        Array[i] = number;
                        kt = true;
                    }
                }
                while (!kt);
            }
            Console.WriteLine("---------------------");
        }
        public static bool IsSymmetryArray(int[] Array)
        {
            for(int i = 0; i < Array.Length -1; i++)
            {
                if(Array[i] != Array[Array.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void BubbleSort( int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        swap(ref Array[j],ref Array[j + 1]);
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
        public static void Show(int[] Arr)
        {
            Console.WriteLine("Array is :");
            foreach (int item in Arr)
            {
                Console.WriteLine(" {0} ", item);
            }
        }
        public static int Find(int[] Array,int n)
        {
            int min = 0;
            int max = Array.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (max + min) / 2;
                if (Array[mid] == n)
                {
                    return mid;
                }
                else if (Array[mid] < n)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }
    }
}
