using System;

namespace Task7
{
    class TextTransformer
    {
        public static string CheckEnteredString(string enteredString)
        {
            if(string.IsNullOrEmpty(enteredString))
            {
                return NullOrEmpty();
            }
            else
            {
                return ToUpper(enteredString);
            }
        }
        private static string NullOrEmpty()
        {
            return "Now string is not empty...";
        }
        private static string ToUpper(string enteredString)
        {
            string newString = null;
            foreach (char c in enteredString)
            {
                newString = newString + Char.ToUpper(c);
            }
            return newString;
        }
    }
}
