using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bai2
    {
        public static void Main()
        {
            int number1, number2, temp;
            Console.WriteLine("Input your first number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number :");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Affter swap :");
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
            Console.Read();
        }
    }
}
