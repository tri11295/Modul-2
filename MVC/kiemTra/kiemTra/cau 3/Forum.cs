using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra.cau_3
{
    public class Forum
    {
        public static List<Post> PostList = new List<Post>();
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
                Console.WriteLine("Post Management System");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Show list");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option from 1 to 4");
                Console.Write("Option: ");
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
                        Console.WriteLine("Create Post ....");
                        CreatePost();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Calculator ....");
                        Calculator();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Show list ....");
                        ShowList();
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
        public static void CreatePost()
        {
            Post newPost = new Post();
            Id += 1;
            newPost.Id = Id;
            Console.WriteLine("Please Input Title");
            newPost.Title = Console.ReadLine();
            Console.WriteLine("Please Input Content");
            newPost.Content = Console.ReadLine();
            Console.WriteLine("Please Input Author");
            newPost.Author = Console.ReadLine();
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please Input Rate");
                newPost.Rates[i] = int.Parse(Console.ReadLine());
            }
            PostList.Add(newPost);
        }
        public static void Calculator()
        {
            foreach(Post newPost in PostList)
            {
                newPost.CalcultorRate();
            }
        }
        public static void ShowList()
        {
            foreach (Post newPost in PostList)
            {
                Console.WriteLine(newPost.Display());
            }
        }
    }
}
