using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Write a program and ask the user to enter a number. The number should be between 1 to 10.
              If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
              (This logic is used a lot in applications where values entered into input boxes need to be validated.)
             */
            int number = 11;
            string legit = (number > 0 && number <= 10) ? "Valid" : "Invalid";
            Console.WriteLine(legit);
        }
    }
}
