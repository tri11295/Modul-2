using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra2.cau3
{
    public class Account : IAccount
    {
        private int balance;
        public int AccountId { get; set; }        
        public int Balance { get => balance; set => balance = value; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string LastName { get; set; }
        public int PayInto()
        {
            return Balance;
        }        
        public string ShowInfo()
        {
            return $"AccountId : {AccountId}\tFirstName : {FirstName}\tLastName : {LastName}" +
                $"\tGender : {Gender}\tBalance : {Balance}";
        }
    }
}
