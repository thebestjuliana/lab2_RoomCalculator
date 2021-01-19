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
                string input = Console.ReadLine();
                double length = double.Parse(input);

                Console.WriteLine("Enter Room Width (in Feet)");
                string input2 = Console.ReadLine();
                double width = double.Parse(input2);

                Console.WriteLine("Enter Room Height (in Feet)");
                string input4 = Console.ReadLine();
                double height = double.Parse(input2);


                double area = width * length;
                Console.WriteLine("Area: " + area + " Feet");

                double perimeter = Math.Pow(width, 2) + Math.Pow(length, 2);
                Console.WriteLine("Perimeter: " + perimeter + " Feet");

                double volume = width * length * height;
                Console.WriteLine("Volume: " + volume + " Feet");

                Console.WriteLine("Continue? (y/n)");

                string input3 = Console.ReadLine();
                
                if (input3 == "y")
                {
                    again = false;
                } else
                {
                    Console.WriteLine("Thank you! Goodbye!");

                    again = true;
                }

            }


        }
    }
}
