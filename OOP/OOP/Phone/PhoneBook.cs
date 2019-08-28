using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOP.Phone
{
    public class PhoneBook : Phone
    {
        protected string name;
        protected string phone;
        public ArrayList PhoneList = new ArrayList();
        public override void insertPhone(string name, string phone)
        {
            if (PhoneList != null && UserIsExited(name))
            {
               foreach (PhoneItem phoneItem in PhoneList)
               {
                    if(phoneItem.Name == name)
                    {
                        if(phoneItem.Phonenumber != phone)
                        {
                            phoneItem.Phonenumber += ":" + phone;
                        }
                    }
               }
            }
            else
            {
                ////Cach 1:
                /*var newItem = new NewItem()
                {
                    Name = name,
                    PhoneNumber = phone
                };
                PhoneList.Add(newItem);*/

                ////Cach 2:

                PhoneList.Add(new PhoneItem()
                {
                    Name = name,
                    Phonenumber = phone
                });
            }

        }
        public override void removePhone(string name)
        {
            if(PhoneList != null)
            {
                foreach(PhoneItem phoneItem in PhoneList)
                {
                    if(phoneItem.Name == name)
                    {
                        PhoneList.Remove(phoneItem);
                        break;
                    }
                }
            }
        }
        public override void searchPhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Phonenumber's {0} is {1}", name, phoneItem.Phonenumber);
                    }
                }
            }
        }
        public override void updatePhone(string name, string newPhone)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        phoneItem.Phonenumber = newPhone;
                    }
                }
            }
        }
        public override void sort()
        {
            throw new NotImplementedException();
        }

        private bool UserIsExited(string userName)
        {
            if(PhoneList != null)
            {
                foreach(PhoneItem item in PhoneList)
                {
                    if (item.Name == userName)
                        return true;
                }
            }
            return false;
        }
    }
}
