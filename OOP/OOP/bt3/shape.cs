using System;
using System.Collections.Generic;
using System.Text;
using OOP.bt3;

    

namespace OOP.bt3
{
    public class shape
    {
        private location c = new location();

       // public location C { get => c; set => c = value; }

        public string ToString(bool type)
        {
            return type ? "area is: " + Area() : "perimeter is: " + Perimeter(); ;
        }

        public void setLocation(double side1, double side2)
        {
            c.X = side1;
            c.Y = side2;

        }

        public virtual double Area()
        {
            return c.X * c.Y;
        }

        public virtual double Perimeter()
        {
            return (c.X + c.Y) * 2; 
        }
    }
}
