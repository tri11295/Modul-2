using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class bt16
    {
        public static string change(string str)
        {
            if(str.Length > 1){
                return str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            }
            else{
                return str;
            }
        }
        public static void Main()
        {
            Console.WriteLine(change("NguyenQuangTri"));
        }
    }
}
