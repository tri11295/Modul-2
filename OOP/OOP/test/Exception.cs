using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace OOP.test
{
    public class Excep
    {
        public static void Main()
        {
            FileStream file = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\input{DateTime.Now.ToString("dd-MM-yyyy")}.txt", FileMode.Append);
            try
            {
                Console.WriteLine("Input a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}/{1} = {2}", a, b, a / b);
            }
            catch (DivideByZeroException div)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Log]:{DateTime.Now.ToString("dd / MM / yyyy hh:mm:ss:tt")}:{div.Message}");
                }
                Console.WriteLine("Error:{0} ", div.Message);
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("go to finally");
            }

            file.Close();
            FileStream file1 = new FileStream($"D:\\codegym\\modul 2\\baitap\\Modul-2\\OOP\\OOP\\test\\input{DateTime.Now.ToString("dd-MM-yyyy")}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file1))
            {
                var content = reader.ReadToEnd();
                Console.Write(content);
            }
        }
    }
}



