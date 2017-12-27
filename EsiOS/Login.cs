using System;
using System.Collections.Generic;
using System.Text;

namespace EsiOS
{
    public class Login
    {
        public Login()
        {
            Console.Write("Username:");
            var user = Console.ReadLine();
            Console.Write("Password:");
            var pass = Console.ReadLine();
            if (user == "admin" && pass == "1234")
            {
                Kernel.isLogged = true;
                Console.WriteLine("Welcome " + user);
            }
            else
            {
                Console.WriteLine("Wrong User/pass");
                Console.WriteLine("retry");

            }
        }
    }
}
