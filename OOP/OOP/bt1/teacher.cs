using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class bt1
    {
        public class Person
        {
            public int age;

            public void SetAge(int n)
            {
                age = n;
            }
            public virtual void Greeting()
            {
                Console.WriteLine(" Person Hello");
            }
        }

        public class Student : Person
        {
            public void ShowAge()
            {
                Console.WriteLine("My age is {0} year old", age);
            }
            public void GoToClass()
            {
                Console.WriteLine("I am go to class");
            }

        }

        public class Teacher : Person
        {
            public string Subject;
            public void Explain()
            {
                Console.WriteLine("Explain begin");
            }

            public void ShowAge()
            {
                Console.WriteLine("My age is {0} years old", age);
            }

            public override void Greeting()
            {
                base.Greeting();
                Console.WriteLine("Hello Student");
            }
        }
        class StudentAndTeacherTest
        {
            static void Main() {
                Person myPerson = new Person();
                myPerson.Greeting();

                Student myStudent = new Student();
                myStudent.SetAge(21);
                myStudent.ShowAge();
                myStudent.Greeting();

                Teacher myTeacher = new Teacher();
                myTeacher.SetAge(30);
                myTeacher.ShowAge();
                
                myTeacher.Greeting();
                myTeacher.Explain();
            }
        }
    }
}
