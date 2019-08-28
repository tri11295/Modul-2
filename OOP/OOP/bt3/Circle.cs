using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.bt3
{
    public class Circle : shape
    {
        private double radius;
        private double pi;

        public double Side1 { get => radius; set => radius = value; }
        public double Side2 { get => pi; set => pi = value; }

        public void SetCircle()
        {
            setLocation(radius, pi);
        }

        public override double Area()
        {
            return radius * radius * pi;
        }

        public override double Perimeter()
        {
            return radius * 2 * pi;
        }
    }
}
