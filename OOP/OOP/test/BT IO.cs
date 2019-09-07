using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace OOP.test
{
    class BT_IO
    {
        public static FileStream file = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\input.txt", FileMode.Create);
        public static FileStream file1 = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\output.txt", FileMode.Create);
        public static void Main()
        {
            Console.WriteLine("Input so phan tu");
            int n = Convert.ToInt32(Console.ReadLine());                    
                         
            int[] Array = new int[n];
            for (int i = 0; i < n; i++)
            {                   
               Console.WriteLine("Nhap phan tu thu {0} ", i + 1);
               Array[i] = Convert.ToInt32(Console.ReadLine());
            }           
            
            writeArray(n, Array);
            readArray();
            Console.Read();
        }

        public static void writeArray(int n , int[] Array)
        {            
            using (StreamWriter write = new StreamWriter(file))
            {
                write.WriteLine(n);
                write.WriteLine(string.Join(",", Array));
            }
            file.Close();
        }

        public static void readArray()
        {
            FileStream file = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\input.txt", FileMode.Open);

            using (StreamReader read = new StreamReader(file))
            {
                var string1 = read.ReadLine();
                var string2 = read.ReadLine();

                var ArrayNum = string2.Split(",");
              
                for(int i = 0; i < ArrayNum.Length; i++)
                {
                    var min = int.Parse(ArrayNum[i]);
                    var pos = i;
                    for(int j = i +1;j < ArrayNum.Length; j++)
                    {
                        if(min > int.Parse(ArrayNum[j]))
                        {
                            min = int.Parse(ArrayNum[j]);
                            pos = j;
                        }                                           
                    }
                    var temp = ArrayNum[pos];
                    ArrayNum[pos] = ArrayNum[i];
                    ArrayNum[i] = temp;

                }              

                using (StreamWriter write = new StreamWriter(file1))
                {
                    int sum = 0;
                    for (int i = 0; i < ArrayNum.Length; i++)
                    {
                        sum += int.Parse(ArrayNum[i]);                                              
                    }
                    write.WriteLine("Tổng các số là {0}", sum);

                    write.Write("Các số chẵn là : ");
                    for (int i = 0; i < ArrayNum.Length; i++)
                    {
                        if (int.Parse(ArrayNum[i]) % 2 == 0)
                        {
                            write.Write(ArrayNum[i] + " ");
                        }
                    }

                    write.WriteLine();
                    write.Write("Dãy số theo thứ tự tăng dần : ");
                    for(int i = 0; i < ArrayNum.Length; i++)
                    {
                        write.Write(ArrayNum[i] +" ");
                    }


                }                                        
                
            }
            file.Close();           
            
            
        }

       
        
    }
}
