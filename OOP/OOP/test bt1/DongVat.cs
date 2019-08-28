using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test_bt1
{
    class DongVat
    {
        private string name;
        private string colorCoat;
        private int leg;

        public string Name { get => name; set => name = value; }
        private string ColorCoat { get => colorCoat; set => colorCoat = value; }
        private int Leg { get => leg; set => leg = value; }

        public void landAnimal(string name, string colorCoat, int leg)
        {
            name = Name;
            colorCoat = ColorCoat;
            leg = Leg;
        }

    }
}
