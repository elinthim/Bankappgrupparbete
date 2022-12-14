using System;
using System.Collections.Generic;
using System.Threading;


namespace Bankappgrupparbete
{
    public class Bank
    {
        string Username;
        string Password;

        //Admin a = new Admin("",""); 

        public string username { get { return Username; } set { Username = value; } }
        public string password { get { return Password; } set { Password = value; } }

        List<string> userList = new List<string>();
        List<string> passList = new List<string>();
        List<string> banklist = new List<string>();
        DateTime currentDateTime = DateTime.Now;

        public Bank(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void Start()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|   Välj ett av altenativen     |");
            Console.WriteLine("|  1. Logga in som Admin        |");
            Console.WriteLine("|  2. Logga in som Privat kund  |");
            Console.WriteLine("|  3. Logga ut                  |");
            Console.WriteLine("|                               |");
            Console.WriteLine(DateTime.Now.ToString("|   dddd, dd MMMM yyyy    |"));
            Console.WriteLine("---------------------------------");
            Console.Write("Val : ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (input)
            {
                case 1:
                    adminInlogged();
                    break;
                case 2:
                    customerinlog();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Tack för idag");
                    Console.ReadKey();
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
                if (adminUser == "admin" && adminPass == "admin") { admin(); }
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
        public void customerinlog()
        {
            bool gameOver = false;
            int num = 0;
            while (gameOver == false)
            {
                Console.Write("Användarnamn privatperson : ");
                string customerinlog = Console.ReadLine();
                Console.Write("Password privatkund : ");
                string customerPass = Console.ReadLine();
                num++;


                var userfound = userList.Find(i => i.Equals(customerinlog));
                var userfound1 = passList.Find(i => i.Equals(customerPass));

                if (userfound == customerinlog && userfound1 == customerPass)
                {
                    usermeny();

                }
                else if (userfound != customerinlog && userfound1 != customerPass)
                {
                    Console.WriteLine("Fel inmatning, försök igen!");
                    gameOver = false;
                    Console.Clear();

                }
                if (num < 3)
                {
                    Console.WriteLine("Fel inmatning försök igen");
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
                    gameOver = true;
                }


            }
            Start();
        }
        public void admin()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till inloggningen för Admin !!");
            Console.WriteLine("1. Lägga till användare");
            Console.WriteLine("2. Användare ");
            Console.WriteLine("3. Logga ut");
            int adminInput = int.Parse(Console.ReadLine());
            if (adminInput == 1) { addUser(); }
            else if (adminInput == 2) { checkUser(); }
            else if (adminInput == 3) { Console.Clear(); Start(); }
            Console.ReadKey();
        }
        public void addUser()
        {
            int total;
            int num = 1;
            Console.Clear();
            try
            {
                Console.Write("Hur många vill du lägga till : ");
                total = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                for (int i = 0; i < total; i++)
                {
                    Console.Write($"Användarnamn {i + 1} : ");
                    string input = Console.ReadLine();
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
                    Console.Write($"PassWord {i + 1} : ");
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
            catch
            {
                Console.WriteLine("Fel typ av inmatning använd siffror\nTryck enter");
                Console.ReadKey();
            }
            addUser();

        }
        public void checkUser()
        {
            Console.Clear();
            Console.WriteLine("Här kommer alla användare");
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Tryck Enter för att återvända till start");
            Console.ReadKey();
            admin();
        }
        public void usermeny()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till din användarmenyn");
            Console.WriteLine("1. Se mina bankkonton");
            Console.WriteLine("2. Öppna nytt bankkonto ");
            Console.WriteLine("3. Logga ut");
            int adminInput = int.Parse(Console.ReadLine());
            if (adminInput == 1) { banksaldo(); }
            else if (adminInput == 2) { checkUser(); }
            else if (adminInput == 3) { Console.Clear(); Start(); }
            Console.ReadKey();

                 switch (adminInput)
            {
                case 1:
                    usermeny();
                    break;
                case 2:
                    
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Tack för idag");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }

        }
        public void banksaldo()
        {
            Random random = new Random();
            int number1 = random.Next(1111111,9999999);
            Random random1 = new Random();
            int number2 = random.Next(0, 1000000);

            Console.WriteLine("Kontonummer : " + number1);
            Console.WriteLine("Banksaldo : " + number2  + " kr");
        }
    }
}

