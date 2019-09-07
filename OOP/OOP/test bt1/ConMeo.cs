using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.test_bt1
{
    public class ConMeo : DongVat
    {
        private string ColorEyes;
        private string NameBoss;

        public ConMeo()
        {

        }
        public ConMeo(string Name,string ColorCoat,int Leg,string ColorEyes,string NameBoss)
        {

        }

        public override void BietBay()
        {
            Console.WriteLine("Meo khong biet bay");
        }

        public void Xuat()
        {
            Console.WriteLine("Meo {0} cua {1} co long {2}", this.Name, this.NameBoss,this.ColorCoat);
        }


    }
}
