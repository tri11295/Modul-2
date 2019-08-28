using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.bt4
{
    public class AnimalTest
    {
        public static void Main()
        {
            Console.WriteLine("*******Chicken*******");
            var chip = new Chicken();
            Console.WriteLine("Chip say: {0}", chip.MakeSound());
            Console.WriteLine("Chip eats: {0}", chip.HowToEat());

            Console.WriteLine("*******Tiger*******");
            var puma = new Tiger();
            Console.WriteLine("puma says: {0}", puma.MakeSound());
            Console.WriteLine("puma eats: {0}", puma.HowToEat());

            Console.WriteLine("*******Apple*******");
            var RedApple = new Apple();
            Console.WriteLine(RedApple.HowToEat());

            Console.WriteLine("*******Orange*******");
            var BigOrange = new Orange();
            Console.WriteLine(BigOrange.HowToEat());
        }
    }
}
