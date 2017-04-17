using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome! Would you like to create a new user account? (Yes or No): ");
            string response = Console.ReadLine();
            if (response == "Yes" || response == "yes" || response == "y" || response == "Y")
            {
                
                NewUser newUser = new NewUser();
                newUser.CreateUsername();
               
                
            }
            else
            {
                Console.WriteLine("Would you like to be redirected to the log in page, or exit?");
                Console.Write("(\"Login\" or \"Exit\"): ");
                string secondResponse = Console.ReadLine();
                if (secondResponse == "Login" || secondResponse == "login")
                {
                    NewUser returningUser = new NewUser();
                    returningUser.ValidateUsername();
                }
                else if (secondResponse == "Exit" || secondResponse == "exit")
                {
                    Console.WriteLine("That's okay! See you next time.");
                }
            }

            Console.ReadKey();
        }
    }
}
