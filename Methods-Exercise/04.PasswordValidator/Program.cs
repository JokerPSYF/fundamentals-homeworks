using System;

namespace _04.PasswordValidator
{
    class Program
    {
        //The password validation rules are:
        //It should contain 6 – 10 characters(inclusive)
        //    It should contain only of letters and digits
        //It should contain at least 2 digits
        //    If it is not valid, for any unfulfilled rule print the corresponding message:
        //"Password must be between 6 and 10 characters"
        //"Password must consist only of letters and digits"
        //"Password must have at least 2 digits"
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBetween6And10 = IsBetweenSixAndTen(password);
            bool isContainsOnlyDigitsAndLetters = ContainOnlyDigitsAndLetters(password);
            bool is2digits = IsTwoDigits(password);
            ValidOrNot(isBetween6And10, isContainsOnlyDigitsAndLetters, is2digits);
        }

        private static void ValidOrNot(bool isBetween6And10, bool isContainsOnlyDigitsAndLetters, bool is2digits)
        {
            if (!isBetween6And10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isContainsOnlyDigitsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!is2digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (is2digits && isBetween6And10 && isContainsOnlyDigitsAndLetters)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool IsTwoDigits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
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

        private static bool ContainOnlyDigitsAndLetters(string password)
        {
            bool IsntSymbol = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    IsntSymbol = false;
                }

            }
            return IsntSymbol;
        }

        private static bool IsBetweenSixAndTen(string password)
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
