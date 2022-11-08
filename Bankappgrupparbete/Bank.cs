using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankappgrupparbete
{
    class Bank
    {
        List<string> Clist = new List<string>();
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

