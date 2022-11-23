using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp9
{
    internal class User
    {
        private string _username;
        private protected string Username;
        private string _password;
        private protected string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }
        public void ShowInfo()
        {
            Console.Write("Username: ");
            string userr = Console.ReadLine();
            Username = userr;
            if (userr.Length > 6)
            {
                Passwword();
                _username = userr;
            }
            else
            {
                Console.WriteLine("Yeniden Daxil Edin");
                ShowInfo();
            }
        }
        public void Passwword()
        {
            Console.Write("Password: ");
            string kod = Console.ReadLine();
            Password = kod;
            if (kod == kod.ToLower())
            {
                Console.WriteLine("Set again Password");
                Passwword();
            }
            else
            {
                _password = kod;
            }
        }

    }

}

