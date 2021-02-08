using System;
using System.Text;
using System.Threading;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();

            bool isItOk = false;

            if (PasswordLenght(password))
            {
                isItOk = true;
            }
            else
            {
                isItOk = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (PasswordLettersAndDigits(password))
            {
                isItOk = true;
            }
            else
            {
                isItOk = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (HaveAtLeast2Digit(password))
            {
                isItOk = true;
            }
            else
            {
                isItOk = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isItOk)
            {
                Console.WriteLine("Password is valid");
            }


        }

        private static bool HaveAtLeast2Digit(string password)
        {
            int count = 0;
            foreach (var symbol in password)
            {
               
                if (char.IsDigit(symbol))
                {
                    count++;
                }

            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool PasswordLettersAndDigits(string password)
        {
            foreach (var symbol in password)
            {
                if (char.IsLetterOrDigit(symbol))
                {
                    
                }
                else
                {
                    return false;
                }

            }

            return true;
        }

        private static bool PasswordLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10) 
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
