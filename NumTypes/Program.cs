using System;

// RectangleAreaCalculator.Program.Main();

namespace RectangleAreaCalculator
{
    class Program
    {
        internal static void Main()
        {
            // Prompt the user for the length.
            Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());

            // Prompt the user for the width.
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            // Calculate the area.
            double area = length * width;

            // Present the length to the user.
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
