using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestInMe_Mini_Project
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool ValidateCredentials(string userName, string password)
        {
            return userName == "MakeSomeMoney" && password == "pa$$word";
        }
    }
}
