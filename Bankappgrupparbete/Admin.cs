using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Bankappgrupparbete
{
    class Admin : Bank
    {
        public Admin(string username, string password) : base(username, password)
        {
        }

        public static void adminInlogg()
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false)
            {
                Console.Write("Användarnamn : ");
                string adminUser = Console.ReadLine().ToLower();
                Console.Write("Password : ");
                string adminPass = Console.ReadLine().ToLower();
                num++;
                if (adminUser == "admin" && adminPass == "admin")
                {
                    Console.Clear();
                    Console.WriteLine("Välkommen till inloggningen för Admin !!");
                    Console.WriteLine("1. Lägga till användare");
                    Console.WriteLine("2. Kolla något annat");
                    int adminInput = int.Parse(Console.ReadLine());
                    if (adminInput == 1)
                    {
                        addUser();
                    }
                    gameOver = true;
                    Console.ReadKey();
                }
                else
                {
                    if (num < 3)
                    {
                        Console.WriteLine("Fel inmatning, försök igen!");
                        gameOver = false;
                        Console.Clear();
                    }
                    else if (num == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Nu har du ett försök kvar!!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Va fan, jag sa ju till dig!!. Nu loggas du ut!");
                        break;
                    }
                }
            }
        }
        public static void addUser()
        {
            Console.WriteLine("Ange info om den nya användaren");
            Console.WriteLine("-------------------------------");
            Console.Write("Användarnamn : ");



        }
    }
}
