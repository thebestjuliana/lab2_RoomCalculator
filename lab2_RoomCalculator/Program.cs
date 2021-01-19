using System;

namespace lab2_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            bool again = false;
            while (again == false)
            {



                Console.WriteLine("Enter Room Length (in Feet)");
                string lengthInput = Console.ReadLine();
                double length = double.Parse(lengthInput);

                Console.WriteLine("Enter Room Width (in Feet)");
                string widthInput = Console.ReadLine();
                double width = double.Parse(widthInput);

                Console.WriteLine("Enter Room Height (in Feet)");
                string heightInput = Console.ReadLine();
                double height = double.Parse(heightInput);


                double area = width * length;
                Console.WriteLine("Area: " + area + " Feet");

                double perimeter = width * 2 + length * 2 ;
                Console.WriteLine("Perimeter: " + perimeter + " Square Feet");

                double volume = area * height;
                Console.WriteLine("Volume: " + volume + " Cubed Feet");

                Console.WriteLine("Continue? (y/n)");

                string input = Console.ReadLine();
                
                if (input == "y")
                {
                    again = false;
                } 
                else
                {
                    Console.WriteLine("Thank you! Goodbye!");

                    again = true;
                }

            }


        }
    }
}
