using System;
using System.Collections.Generic;
using System.Text;
using OOP.StudentManagementSystem.Model;
namespace OOP.StudentManagementSystem
{
    public class StudentTest
    {
        public static Student NewStudent = new Student();
        public static int ID1 = 0;
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Interest new Student");
                Console.WriteLine("2. View list of Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit");
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
                        Console.WriteLine("Creat Info new Student");
                        CreatStudent();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of Student");
                        NewStudent.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Search Student");
                        Console.WriteLine("Iput Name");
                        string name = Console.ReadLine();
                        NewStudent.Search(name);
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

       

        public static void CreatStudent()
        {
            ID1 += 1;
            NewStudent.ID1 = ID1;

            Console.WriteLine("Please Input Student Fullname:");
            NewStudent.FullName1 = Console.ReadLine();

            Console.WriteLine("Please Input Class Name:");
            NewStudent.Class1 = Console.ReadLine();
           
            Console.WriteLine("Please Input Native:");
            NewStudent.Native1 = Console.ReadLine();

            Console.WriteLine("Please Input PhoneNo:");
            NewStudent.PhoneNo1 = Console.ReadLine();

            Console.WriteLine("Please Input Day Of Birth:");
            NewStudent.DayOfBirth1 = Console.ReadLine();

            Console.WriteLine("Please Input Mobile:");
            NewStudent.Mobile1 = Convert.ToInt32(Console.ReadLine());

            NewStudent.InsertStudent(ID1);
        }
    }
}
