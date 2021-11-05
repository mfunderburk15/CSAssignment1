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
            int number = 5;
            string legit = (number > 0 && number <= 10) ? "Valid" : "Invalid";
            Console.WriteLine(legit);

            /*
             Write a program which takes two numbers from the console and displays the maximum of the two.
             */
            int number1 = 3;
            int number2 = 3;
            int max = (number1 > number2 || number1 == number2) ? number1 : number2;
            Console.WriteLine(max);

            /*
                Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. 
             */
            int width = 12;
            int height = 8;
            if (width > height)
            {
                Console.WriteLine("landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("portrait");
            }
            else
            {
                Console.WriteLine("square image");
            }

        }
    }
}
