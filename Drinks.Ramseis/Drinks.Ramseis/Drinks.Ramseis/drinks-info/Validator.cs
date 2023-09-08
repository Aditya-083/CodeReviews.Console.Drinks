﻿namespace Drinks.Ramseis
{
    internal class Validator
    {
        public static bool IsStringValid(string input)
        {
            if (String.IsNullOrEmpty(input)) { return false; }
            
            foreach (char c in input)
            {
                if (!Char.IsLetter(c) && c != '/' && c != ' ') { return false; }
            }
            return true;
        }

        public static bool IsIdValid(string input)
        {
            if (String.IsNullOrEmpty(input)) { return false; }
            foreach(char c in input)
            {
                if (!Char.IsDigit(c)) { return false; }
            }
            return true;
        }
    }
}
