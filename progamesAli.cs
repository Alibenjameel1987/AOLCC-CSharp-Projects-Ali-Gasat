using System;

namespace AOLCC_Projects
{
    class Program
    {
        static void Main()
        {
            #region Student Info
            Console.WriteLine("Student: Ali Jamil Khalaf Al Gasat");
            Console.WriteLine("Program: Software Development (AOLCC)");
            Console.WriteLine("Contact: +1 (226) 246-4410");
            Console.WriteLine("Email: Alshdaifatali@gmail.com\n");
            #endregion

            #region Shipping Calculator
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            // Get package weight with validation
            double weight;
            Console.WriteLine("Enter package weight (kg):");
            while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy. Have a good day.");
                Console.ReadLine();
                return;
            }

            // Get dimensions with validation
            double width, height, length;
            Console.WriteLine("Enter package width (cm):");
            while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            Console.WriteLine("Enter package height (cm):");
            while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            Console.WriteLine("Enter package length (cm):");
            while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            // Check total dimensions
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big for shipping.");
                Console.ReadLine();
                return;
            }

            // Calculate quote
            double quote = (width * height * length * weight) / 100;
            Console.WriteLine($"\nShipping quote: ${quote:F2}");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
            #endregion
        }
    }
}