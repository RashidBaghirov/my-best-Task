using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Admin:User
    {
    
            public bool IsSuperAdmin;
            public string Section;

            public Admin(bool isSuperAdmin, string Section, string username, string password) : base(username, password)
            {
                IsSuperAdmin = isSuperAdmin;
              this. Section = Section;
            }

            public void Showinfoanddata()
            {
                ShowInfo();
                Console.WriteLine($" True or False:  {IsSuperAdmin}, Section: {Section}, Username:{Username},Password:{Password}");
            }
    }
}
