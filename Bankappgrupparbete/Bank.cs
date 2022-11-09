using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Bankappgrupparbete
{
    class Bank
    {
        string Username;
        string Password;
        

        public string username { get { return Username; } set { Username = value; } }
        public string password { get { return Password; } set { Password = value; } }

        List<string> userList = new List<string>();
        List<string> passList = new List<string>();

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
                    adminInlogged();
                    break;
                default:
                    break;
            }
        }
        public void adminInlogged()
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false)
            {
                Console.Write("Användarnamn Admin : ");
                string adminUser = Console.ReadLine().ToLower();
                Console.Write("Password Admin : ");
                string adminPass = Console.ReadLine().ToLower();
                num++;
                if (adminUser == "admin" && adminPass == "admin")  {admin();}
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
        public void admin()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till inloggningen för Admin !!");
            Console.WriteLine("1. Lägga till användare");
            Console.WriteLine("2 Användare ");
            Console.WriteLine("3. Logga ut");
            int adminInput = int.Parse(Console.ReadLine());
            if (adminInput == 1) { addUser(); }
            else if (adminInput == 2) { checkUser(); }
            else if (adminInput == 3) { Console.Clear(); Start();  }
            Console.ReadKey();
        }
        public void addUser()
        {
            int num = 1;
            Console.Clear();
            Console.Write("Hur många vill du lägga till : ");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            
            for (int i = 0; i < total; i++)
            {
                Console.Write($"Användarnamn {i + 1} : ");
                var input = Console.ReadLine();
                if (input.Length < 5)
                {
                    
                    Console.WriteLine("Minst 5 tecken TACK");
                    Thread.Sleep(5000);
                    addUser();
                }
                userList.Add(input);
            }
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < total; i++)
            {
                Console.Write($"PassWord {i+1} : ");
                var input = Console.ReadLine();
                if (input.Length < 5)
                {
                    Console.WriteLine("Minst 5 tecken TACK");
                    addUser();
                }
                passList.Add(input);
            }
            Console.Clear();
            admin();
        }
        public void checkUser()
        {
            Console.WriteLine("Här kommer alla användare");
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine(" Tryck Enter för att återvända till start");
            Console.ReadKey(); 
            admin();
        }








    }

}

