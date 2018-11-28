using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Users
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CCNumber { get; set; }
        public string CCExp { get; set; }
        public int CCSec { get; set; }
        public string Password { get; set; }
        public string Authentication { get; set; }

        public Users() { }

        public Users(string name, string username, string email, string address, string cCNumber, string cCExp, int cCSec, string password, string authentication)
        {
            Name = name;
            Username = username;
            Email = email;
            Address = address;
            CCNumber = cCNumber;
            CCExp = cCExp;
            CCSec = cCSec;
            Password = password;
            Authentication = authentication;
        }
    }
}
