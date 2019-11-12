using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra.cau_3
{
    public class Post : IPost
    {
        public int Id;
        public string Title;
        public string Content;
        public string Author;
        public float AverageRate;
        public int[] Rates = new int[4];

        public string Display()
        {
            return $"ID : {Id} \tTitle : {Title} \tContent : {Content} \tAverageRate : {AverageRate}";
        }      

        public void CalcultorRate()
        {
            int sum = 0;
            foreach(int rate in Rates)
            {
                sum += rate;
            }
            AverageRate = sum / 4;
        }
    }
}
