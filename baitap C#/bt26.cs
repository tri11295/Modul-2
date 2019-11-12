using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt26
    {
        public static Boolean isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if (n == 1)
            {
                return false;
            }
            if(n == 2)
            {
                return true;
            }
            for(int i = 2;i <= x; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main()
        {
            int count = 0;
            int sum = 0; 
            for(int n = 1;count < 500; n++)
            {
                if (isPrime(n)){
                    sum += n;
                    count++;
                }
            }
            Console.WriteLine("Sum of the first 500 prime numbers {0}", sum);
        }
    }
}
