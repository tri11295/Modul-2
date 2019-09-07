using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.kiemTra.cau_3
{
    public class Post : IPost
    {

        public int Id;
        public string Tittle;
        public string Content;
        public string Author;
        public float AverageRate;

        public int[] Rate = new int[4];
        public void CalculatorRate()
        {
            int sum = 0;
            for(int i = 0; i < Rate.Length; i++)
            {
                sum += Rate[i];
            }
            AverageRate = sum / Rate.Length;
        }

        public string Display()
        {
            return $"Id: {Id}\tTitle: {Tittle}\tContent: {Content}\tAuthor: {Author}\tAverage Rate: {AverageRate}";
        }
    }
}
