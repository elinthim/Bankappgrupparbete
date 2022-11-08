using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Bankappgrupparbete
{
    class Customer : Bank
    {
        private string Username;
        private string Password;



        public string username { get { return Username; } set { Username = value; } }
        public string password { get { return Password; } set { Password = value; } }



    }

}
