using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.User1
{
    public class User : IUser
    {
        public List<int?> PhoneList = new List<int?>();

        protected int id;
        protected string name;
        protected string passWord;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public string Display()
        {
            if (PhoneList == null || PhoneList.Count == 0)
                return $"Id: {id} Name: {name} Password: {passWord}";
            else
                return $"Id: {id} Name: {name} Password: {passWord} Phone list: {string.Join(" - ", PhoneList)}";
        }
    }
}