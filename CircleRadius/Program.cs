using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{
    class Program
    {
        private static Circle _circle;

        static void Main(string[] args)
        {
            AskForRadius();
            DisplayMainMenu();
        }

        private static void AskForRadius()
        {
            Console.WriteLine("Please enter the radius of the circle");
            double radius = Utility.VerifyRadius();
            _circle = new Circle(radius);
        }

        private static void DisplayMainMenu()
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Add to Circle Radius");
                Console.WriteLine("2. Subtract from Circle Radius");
                Console.WriteLine("3. Calculate Circle Circumference");
                Console.WriteLine("4. Calculate Circle Area");
                Console.WriteLine("5. Exit");

                choice = Utility.VerifyInteger();

                switch(choice)
                {
                    case 1:
                        AddRadius();
                        break;
                    case 2:
                        SubtractRadius();
                        break;
                    case 3:
                        CalculateCircumference();
                        break;
                    case 4:
                        CalculateArea();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (choice != 5);
        }

        private static void AddRadius()
        {
            Console.WriteLine("Please enter value to add to radius");
            double num = Utility.VerifyRadius();

            _circle.AddToRadius(num);
        }

        private static void SubtractRadius()
        {
            Console.WriteLine("Please enter value to subtract from radius");
            double num = Utility.VerifyRadius();

            if(!_circle.SubtractFromRadius(num))
            {
                Console.WriteLine("Error: The value given was larger than radius of the circle.");
                Console.WriteLine("The radius of the circle is " + _circle.Radius);
                Console.WriteLine("Press any key to back to main menu...");
                Console.ReadKey();
            }
        }

        private static void CalculateCircumference()
        {
            Console.Clear();
            Console.WriteLine("The circumference of the circle is: " + _circle.GetCircumference());
            Console.WriteLine("Press any key to back to main menu...");
            Console.ReadKey();
        }


        private static void CalculateArea()
        {
            Console.Clear();
            Console.WriteLine("The area of the circle is: " + _circle.GetArea());
            Console.WriteLine("Press any key to back to main menu...");
            Console.ReadKey();
        }
    }
}