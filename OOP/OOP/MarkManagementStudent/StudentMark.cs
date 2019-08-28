using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using OOP.MarkManagement.Model;

namespace OOP.MarkManagement
{
    public class StudentMark :IStudentMark
    {
        private string Fullname;
        private int ID;
        private string Class;
        private string Semeter;
        private float AverageMark;

        public string Fullname1 { get => Fullname; set => Fullname = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Class1 { get => Class; set => Class = value; }
        public string Semeter1 { get => Semeter; set => Semeter = value; }
        public float AverageMark1 { get => AverageMark; private set => AverageMark = value; }

        public int[] SubjectMarkList = new int[5];
        ArrayList StudentList = new ArrayList();
        public void Display()
        {
            foreach(StudentMarkItem studentMarkItem in StudentList)
            {
                Console.WriteLine("ID: {0} FullName: {1} Class: {2} Semeter: {3} AverageMark: {4}",
                    studentMarkItem.ID1,
                    studentMarkItem.Fullname1,
                    studentMarkItem.Class1,
                    studentMarkItem.Semeter1,
                    studentMarkItem.AverageMark1);
            }
        }

        public void AveCal()
        {
            float total = 0f;
            for(int i = 0; i < SubjectMarkList.Length; i++)
            {
                total += SubjectMarkList[i]; 
            }
            AverageMark = total / 5;
        }

        public void InsertStudent(int index)
        {
            AveCal();
            var studentMarkItem = new StudentMarkItem
            {
                Fullname1 = Fullname,
                ID1 = ID,
                Class1 = Class,
                Semeter1 = Semeter,
                AverageMark1 = AverageMark

            };
           
            StudentList.Add(studentMarkItem);
        }
       
    }
}
