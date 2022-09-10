using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Stock_App
{
    public class User
    {
        public User(string _userName ,string _passWord)
        {
           userName = _userName;
            password = _passWord;
        }

        public string userName { get; set; }
        public string password { get; set; } 

    }
}
