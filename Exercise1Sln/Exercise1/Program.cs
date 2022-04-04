using System;

namespace Exercise1
{
    internal class Program
    {


        // Example with same logic as a reusable method
        public static string ReverseString(string input)
        {
            string reversedString = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + input[i];
            }

            return reversedString;
        }


        static void Main(string[] args)
        {
            string textInput = "My test string";
            string reversedString="";

            for (int i = textInput.Length -1; i >= 0 ; i--)
            {
                reversedString = reversedString + textInput[i];
            }

            Console.WriteLine(reversedString);

            // Example Calling Using a Method 

            reversedString = ReverseString(textInput);

            Console.WriteLine(reversedString);

        }
    }
}
