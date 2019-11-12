using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra.cau_2
{
    public class cau2
    {
        public static int[] Array;
        public static int n;
        public static int value;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Array");
                Console.WriteLine("2. Is Increase Array");
                Console.WriteLine("3. Sort Array");
                Console.WriteLine("4. Search Array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please select an option from 1 to 5");
                Console.Write("Option: ");
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
                        Console.WriteLine("Create Post ....");
                        CreatArray();
                        break;
                    }
                case 2:
                    {                       
                        if (IsIncreaseArray(Array))
                        {
                            Console.WriteLine("Array is Increase Array");
                        }
                        else
                        {
                            Console.WriteLine("Array is Not Increase Array");
                        }                        
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Sort Array ....");
                        SortArray(Array);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Search Array");
                        Console.WriteLine("Please Input Value you want Search");
                        value = int.Parse(Console.ReadLine());
                        if(SearchArray(Array, value) > -1)
                        {
                            Console.WriteLine("Index of value {0}", SearchArray(Array, value));
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }                        
                        break;
                    }
                case 5:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void CreatArray()
        {
            Console.WriteLine("Input so phan tu");            
            do
            {
                int.TryParse(Console.ReadLine(), out n);
            }
            while (n <= 0);         
            Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                var number = 0;
                var t = false;
                do
                {
                    Console.WriteLine("Nhap phan tu thu {0} ", i + 1);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        Array[i] = number;
                        t = true;
                    }
                }
                while (!t);
            }
            Console.WriteLine(string.Join(",", Array));
        }
        public static bool IsIncreaseArray(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void SortArray(int[] Array)
        {
            for (int i = 0; i <= Array.Length - 1; i++)
            {
                var min = Array[i];
                var pos = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < min)
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
        public static int SearchArray(int[] Array,int value)
        {
          
            int min = 0;
            int max = Array.Length - 1;

            while (min <= max)
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

            return -1;
        }
    }
}
