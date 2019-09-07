using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test_bt1
{   
    public abstract class DongVat
    {
        private string name;
        private string colorCoat;
        private int leg;

        public string Name { get => name; set => name = value; }
        public string ColorCoat { get => colorCoat; set => colorCoat = value; }
        public int Leg { get => leg; set => leg = value; }

        public DongVat()
        {

        }

        public DongVat(string Name,string ColorCoat,int Leg)
        {

        }

        public abstract void BietBay();

    }
}
