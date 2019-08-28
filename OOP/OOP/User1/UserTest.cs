using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.User1
{
    public class UserTest
    {
       
        public static Dictionary<int, User> UserList = new Dictionary<int, User>();
        public static int Id = 0;
        public static void Main()
        {
            InitMenu();

        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Check User");
                Console.WriteLine("3. DisPlay All User");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option 1-4");
                Console.WriteLine("Option");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);

            Process(option);
        }

        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Add User");
                        CreatUser();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check User");
                        CheckUser();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Display All User");
                        Display();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }

        public static void CreatUser()
        {
            User newUser = new User();

            Id = Id + 1;
            newUser.Id = Id;

            Console.WriteLine("Please Input Name User :");
            newUser.Name = Console.ReadLine();

            Console.WriteLine("Please Input PassWord :");
            newUser.PassWord = Console.ReadLine();

            string answer;
            do
            {
                Console.WriteLine("Do You Want Add PhoneNumber");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("Enter Phone Number");
                    newUser.PhoneList.Add(int.Parse(Console.ReadLine()));
                }
            }
            while(answer.ToLower() == "yes");


            UserList.Add(newUser.Id, newUser);
        }

        public static void CheckUser()
        {
            Console.Write("Please input user name: ");
            var name = Console.ReadLine();

            Console.Write("Please input passsword: ");
            var password = Console.ReadLine();

            var isExits = false;
            foreach (KeyValuePair<int, User> item in UserList)
            {
                if (item.Value.Name == name && item.Value.PassWord == password)
                {
                    isExits = true;
                    break;
                }
            }
            if (isExits)
            {
                Console.WriteLine("User checked");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        public static void Display()
        {
            foreach (KeyValuePair<int, User> item in UserList)
            {
                Console.WriteLine(item.Value.Display());
            }
        }
    }
}
    

