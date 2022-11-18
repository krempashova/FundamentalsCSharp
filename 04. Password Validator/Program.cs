using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine(); //login
            bool isLengthValid = IsPasswordLengthValid(password);
            bool isPassAlphanumeric = IsPasswordAlphaNumeric(password);
            bool hasTwoDigits = IsPasswordContaingAtLeastTwoDigits(password);
            if (!isLengthValid)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            if (!isPassAlphanumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLengthValid && isPassAlphanumeric && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }
        //•	It should contain at least 2 digits 
        static bool IsPasswordContaingAtLeastTwoDigits(string password)
        {
            int digitsCnt = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCnt++;
                }
            }

            return digitsCnt >= 2;
        }

        //•	It should contain only letters and digits
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach(char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    
                    return false;
                }
            }

            return true;
        }

    

        //	It should contain 6 – 10 characters (inclusive)
        static bool IsPasswordLengthValid( string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        




        
       
    }
}
