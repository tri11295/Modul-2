using System;
using System.Collections.Generic;
using System.Text;

namespace kiemTra2.cau3
{
    public class AccountList
    {
        public static List<Account> Account = new List<Account> ();
        public static int AccountId = 0;
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
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Pay Info");
                Console.WriteLine("3. Show Data");
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
                        Console.WriteLine("Create Account ....");
                        CreateAccount();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("PayInto ....");
                        payInto();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Show Data ....");
                        ShowData();
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
        /*tạo tài khoản khách hàng và thêm vào danh sách của ngân hàng */
        public static void CreateAccount()
        {
            Account newAccount = new Account();
            newAccount.AccountId = AccountId;
            AccountId++ ;
            Console.WriteLine("Input First Name");
            newAccount.FirstName = Console.ReadLine().ToUpper();
            Console.WriteLine("Input Last Name");
            newAccount.LastName = Console.ReadLine().ToUpper();
            Console.WriteLine("Input Gender");
            newAccount.Gender = Console.ReadLine();
            Console.WriteLine("Input Balance You Want Add Your Account");
            newAccount.Balance = int.Parse(Console.ReadLine());
            Account.Add(newAccount);
        }
       /* Hàm này sẽ yêu cầu người dùng nhập vào họ và tên của người muốn nạp tiền vào, 
        nêu trùng khớp thì sẽ cho phép người dùng nạp tiền vào tài khoản đó*/
        public static void payInto()
        {
            Console.WriteLine("Input First Name Of Your Account ");
            var firstName = Console.ReadLine().ToUpper();
            Console.WriteLine("Input Last Name Of Your Account");
            var lastName = Console.ReadLine().ToUpper();
            foreach (Account newAccount in Account)
            {
                if(firstName == newAccount.FirstName && lastName == newAccount.LastName)
                {
                    Console.WriteLine("Input Money You Want Add Into Your Blance");
                    var money = int.Parse(Console.ReadLine());
                    newAccount.Balance =  newAccount.PayInto() + money;
                }
                else
                {
                    Console.WriteLine("Can't Find Your Account");
                }
            }
        }
        /*hàm này sẽ hiển thị các thông tin của tài khoản có trong danh sách của ngân hàng*/
        public static void ShowData()
        {
            foreach(Account newAccount in Account)
            {
                Console.WriteLine(newAccount.ShowInfo());
            }
        }
    }
}
