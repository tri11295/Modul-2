using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.bt3
{
    public class Rectangle: shape
    {
        private double side1;
        private double side2;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public void SetSide()
         {
            setLocation(side1, Side2);
         }
    }
}
