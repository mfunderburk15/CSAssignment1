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

            /*
               Your job is to write a program for a speed camera.
               For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
               Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
               If the user enters a value less than the speed limit, program should display Ok on the console.
               If the value is above the speed limit, the program should calculate the number of demerit points.
               For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
               If the number of demerit points is above 12, the program should display License Suspended.
             */

            int speedLimit = 45;
            Console.WriteLine(String.Format("The speed limit is {0}mph", speedLimit));
            int speed = 46;
            Console.WriteLine(String.Format("Your speed was {0}mph", speed));
            int demerit = 0;
            if (speed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int occurance = (speed - speedLimit) / 5;
                demerit += occurance;
                Console.WriteLine(String.Format("you have recieved {0} demerits", demerit));
            }
            if (demerit > 12)
            {
                Console.WriteLine("Say goodbye to your license");
            }
            else if (demerit == 0)
            {
                
            }
            else
            {
                int warning = 12 - demerit;
                Console.WriteLine(String.Format("Be careful only {0} more demerits before you say goodbye to your license", warning));
            }
        }
    }
}
