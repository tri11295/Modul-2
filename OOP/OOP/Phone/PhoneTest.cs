using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Phone
{
    public class PhoneTest
    {
        public static PhoneBook phoneBook = new PhoneBook();
        public static void Main()
        {
            InitMenu();
           
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Management News");
                Console.WriteLine("1. Interest Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please select an option 1-6");
                Console.WriteLine("Option");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 7 || option <= 0);

            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {  
                        Console.WriteLine("Input name");
                        var name = Console.ReadLine();

                        Console.WriteLine("Input number");
                        var phone = Console.ReadLine();

                        phoneBook.insertPhone(name, phone);  

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Remove Phone");
                        Console.Write("input name: ");
                        var name = Console.ReadLine();

                        phoneBook.removePhone(name);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Update Phone");
                        Console.Write("input name: ");
                        var name = Console.ReadLine();

                        Console.Write("input phone: ");
                        var phone = Console.ReadLine();

                        phoneBook.updatePhone(name, phone);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Search Phone");
                        Console.Write("input name: ");
                        var name = Console.ReadLine();
                        phoneBook.searchPhone(name);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Sort");

                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Display");
                        Display();
                        break;
                    }
                case 7:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void Display()
        {
            Console.WriteLine("Name \t\t\t PhoneNumber");
            if(phoneBook.PhoneList !=null && phoneBook.PhoneList.Count > 0)
            {
                foreach(PhoneItem phoneItem in phoneBook.PhoneList)
                {
                    Console.WriteLine("{0}\t\t\t{1}", phoneItem.Name, phoneItem.Phonenumber);
                }
            }
        }
    }
}
