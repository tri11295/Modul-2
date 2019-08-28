using System;
using System.Collections.Generic;
using System.Text;
using OOP.MarkManagement.Model;
namespace OOP.MarkManagement
{
    class StudentMarkTest
    {
        public static StudentMark studentMark = new StudentMark();
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
                Console.WriteLine("3. Average Mark");
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
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Interest new Student");
                        CreatStudent();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" View list of Student");
                        studentMark.Display();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Mark");

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
            studentMark.ID1 = ID1;
            Console.WriteLine("Please Input Student Fullname:");
            studentMark.Fullname1 = Console.ReadLine();
            Console.WriteLine("Please Input Class Name:");
            studentMark.Class1 = Console.ReadLine();
            Console.WriteLine("Please Input Semester:");
            studentMark.Semeter1 = Console.ReadLine();
            Console.WriteLine("Please Input Mark of Subject:");
            for(int i =0;i < studentMark.SubjectMarkList.Length; i++)
            {
                Console.WriteLine("Input Mark Of Subject {0}", i);
                studentMark.SubjectMarkList[i] = int.Parse(Console.ReadLine());
            }

            studentMark.InsertStudent(ID1);
        }

    }
}
