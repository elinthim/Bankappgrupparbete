using System;
using System.Collections.Generic;

namespace Bankappgrupparbete
{
    class Bank
    {
        string username;
        string password;

        public string UserName { get{ return username; } set { username = value; } }

        List<Customer> Clist = new List<Customer>();

        public void Start()
        {
            Console.WriteLine("Hallå");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:

                    break;
                default:
                    break;
            }
        }
        public void userinlogg()
        {
            Console.WriteLine("Skriv in användarnamn");
            string input = Console.ReadLine();
            Console.WriteLine(Clist.Find(i => i.));
        }

    }

}

