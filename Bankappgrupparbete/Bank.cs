using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Bankappgrupparbete
{
    class Bank
    {
        string Username;
        string Password;

        public string username { get { return Username; } set { Username = value; } }
        public string password { get { return Password; } set { Password = value; } }

        List<Customer> Clist = new List<Customer>();

        public Bank(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void Start()
        {
            Console.WriteLine("Välj ett av altenativen");
            Console.WriteLine("1. Logga in som Admin");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Admin.adminInlogg();
                    break;
                default:
                    break;
            }
        }


        





    }

}

