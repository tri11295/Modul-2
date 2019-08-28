using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.bt4
{
    public class Chicken : Animal ,Edible
    {
        public override string MakeSound()
        {
            return "Chip Chip";
        }

        public string HowToEat()
        {
            return "rice";
        }
    }
}
