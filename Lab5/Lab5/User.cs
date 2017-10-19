using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        bool isAdmin = false;

        public User(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }
    }
}
