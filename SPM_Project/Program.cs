using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM_Project
{

        class Program
        {
            static void Main(string[] args)
            {
                Operator ob = new Operator();
                ob.PasswordCheck = "1234";
                ob.CnicCheck = "12345678";
                Console.WriteLine(ob.PasswordCheck);


            }
        }
        class Items
        {
            public string fabric = "";
            public int size = 10;
            public string colors = "";
            public int price = 0;
        }

        class User
        {
            public string name = "";
            public string contact = "";
        }

        class Customer : User
        {
            public int id = 0;
            public string gender = "";
        }

        class Operator : User
        {
            private string cnic = "";
            public string CnicCheck
            {
                get { return cnic; }
                set
                {
                    if (value.Length == 14)
                    {
                        value = cnic;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                }
            }

            public int id = 0;
            private string password = "";
            public string PasswordCheck
            {
                get { return password; }
                set
                {
                    if (value == "123abc")
                    {
                        value = password;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password");
                    }
                }
            }

            public void login() { }
            public void logout() { }
            public void printbill() { }
            public void cashcollect() { }

        }

        class BarCodescanner
        {
            public void scan() { }

        }

        class Printer
        {
            public void printbill() { }
        }

        class Calculator
        {
            public void RecordItem() { }
            public void Total() { }
        }
    }

