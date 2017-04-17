using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestLogin
{
    public class NewUser
    {
        // private string variables for username and password to be implemented by properties
        private string _username;
        private string _password;

        /// <summary>
        /// NewUser() constructor calls CreateUsername() method, then follows
        /// with calling other methods in order if all conditions have been
        /// satisfied.
        /// </summary>
        public NewUser()
        {
            
        } 



        /// <summary>
        /// CreateUsername() method prompts the user for a new username input
        /// and verifies to make sure the input isn't empty. It then assigns 
        /// the input to Username property and method ends by invoking the 
        /// CreatePassword() method.
        /// </summary>
        public void CreateUsername()
        {
            // Clears console window then asks user for username input
            Console.Write("\nType desired username then hit enter: ");
            Username = Console.ReadLine();

            // If statement to throw exception if no imput was entered
            if (Username == "") 
            {
                Console.WriteLine("Username cannot be empty. Please any key to try again.");
                Console.ReadKey();
                CreateUsername();

            }

            Console.Write("\"{0}\" is this correct? (Yes or No): ", Username);
            string response = Console.ReadLine();

            if (response == "Yes" || response == "yes")
            {
                Console.WriteLine("Username {0} has successfully been created!\n", Username);
                CreatePassword();
            }
            else
            {
                Console.WriteLine("Whoops! Let's try that again! (Press any key)");
                Console.ReadLine();
                CreateUsername();
            }
           
        }


        /// <summary>
        /// Similar to the CreateUsername() method, asks for user input
        /// password and verifies to make sure the input isn't empty.
        /// Assigns input to the Password properties and moves on to the
        /// ValidateUsername() method, also called "Login page".
        /// </summary>
        public void CreatePassword()
        {
            Console.Clear();
            Console.WriteLine("Now let's create you a password!");
            Console.Write("Enter password: ");

            // Blacks out text so that password remains secure
            Console.ForegroundColor = ConsoleColor.Black;
            Password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            // Asks re-input to confirm password
            Console.Write("Re-enter password: ");
            Console.ForegroundColor = ConsoleColor.Black;
            string confirmPass = Console.ReadLine(); // Creates new string variable to verify input
            Console.ForegroundColor = ConsoleColor.Gray;

            // Confirming current password input with previous
            if (Password == confirmPass)
            {
                Console.WriteLine("\nCongratulations! You have successfully created a new username and password!\n");
                Console.WriteLine("Please wait, you are being redirected to the login page.");
                Thread.Sleep(4300);
                ValidateUsername();
            }
            else
            {
                Console.WriteLine("Passwords do not match. Press any key to try again try again");
                Console.ReadKey();
                CreatePassword();
            }



        }


        /// <summary>
        /// This is where the user logs in with username chosen earlier.
        /// We verify here that the username input matches the one set
        /// earlier in the Username property. If input is correct, it
        /// invokes the ValidatePassword() method.
        /// </summary>
        public void ValidateUsername()
        {
            Console.Clear();
            Console.Write("Enter username: ");
            string validUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            // Blacks out input for security purposes
            Console.ForegroundColor = ConsoleColor.Black;
            string validPassword = Console.ReadLine();
            // Returns text color
            Console.ForegroundColor = ConsoleColor.Gray;

            if (validUsername != this.Username || validPassword != this.Password)
            {
                Console.WriteLine("Invalid username or password. Press any key to try again.");
                Console.ReadKey();
                ValidateUsername();
            }
            else
            {
                Console.WriteLine("\nYou have successfully signed in!");
                
            }
        }

        public string Username // Username property
        {
            get { return this._username; }
            set { this._username = value; }
        }
        public string Password // Password property
        {
            get { return this._password; }
            protected set { this._password = value; }
        }
    }
}
