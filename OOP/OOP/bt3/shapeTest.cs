using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.bt3
{
    class shapeTest
    {
        public static void Main()
        {
            var rect = new Rectangle();
            rect.Side1= 5.5;
            rect.Side2 = 7.5;
            rect.SetSide();

            Console.WriteLine(rect.ToString(true));
            Console.WriteLine(rect.ToString(false));

            var cir = new Circle();
            cir.Side1 = 10;
            cir.Side2 = 3.14;
            cir.SetCircle();

            Console.WriteLine(cir.ToString(true));
            Console.WriteLine(cir.ToString(false));
        }
    }
}
