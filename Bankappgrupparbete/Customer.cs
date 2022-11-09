using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Bankappgrupparbete
{
    class Customer : Bank
    {
        public Customer(string username, string password) : base(username, password)
        {
        }
    }

}
