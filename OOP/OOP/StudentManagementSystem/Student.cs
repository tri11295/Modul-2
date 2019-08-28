using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using OOP.StudentManagementSystem.Model;

namespace OOP.StudentManagementSystem
{
    public class Student : IStudent
    {
        private string FullName;
        private int ID;
        private string DayOfBirth;
        private string Native;
        private string Class;
        private string PhoneNo;
        private int Mobile;

        public string FullName1 { get => FullName; set => FullName = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string DayOfBirth1 { get => DayOfBirth; set => DayOfBirth = value; }
        public string Native1 { get => Native; set => Native = value; }
        public string Class1 { get => Class; set => Class = value; }
        public string PhoneNo1 { get => PhoneNo; set => PhoneNo = value; }
        public int Mobile1 { get => Mobile; set => Mobile = value; }

        ArrayList StudentList = new ArrayList();

        public void Display()
        {
            foreach(StudentItem studentItem in StudentList)
            {
                Console.WriteLine("ID: {0} FullName: {1} Day OF Birth: {2} Native: {3} Class: {4} PhoneNO: {5} Mobile: {6}",
                    studentItem.ID1,
                    studentItem.FullName1,
                    studentItem.DayOfBirth1,
                    studentItem.Native1,
                    studentItem.Class1,
                    studentItem.PhoneNo1,
                    studentItem.Mobile1);
            }
        }

        public void Search(string name)
        {
            foreach(StudentItem studentItem in StudentList)
            {
                if(name == studentItem.FullName1)
                {
                    Console.WriteLine("ID: {0} FullName: {1} Day OF Birth: {2} Native: {3} Class: {4} PhoneNO: {5} Mobile: {6}",
                    studentItem.ID1,
                    studentItem.FullName1,
                    studentItem.DayOfBirth1,
                    studentItem.Native1,
                    studentItem.Class1,
                    studentItem.PhoneNo1,
                    studentItem.Mobile1);
                    break;
                }
                else
                {
                    Console.WriteLine("Name Of Student Is Not Existed");
                }
            }
        }

        public void InsertStudent(int index)
        {

            var studentItem = new StudentItem()
            {
                FullName1 = FullName,
                ID1 = ID,
                Class1 = Class,
                Native1 = Native,
                DayOfBirth1 = DayOfBirth,
                PhoneNo1 = PhoneNo,
                Mobile1 = Mobile
            };

            StudentList.Add(studentItem);
        }
    }
}
