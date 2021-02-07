using System;

namespace cargo_price_calc
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter height: ");

            double height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter width: ");

            double width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter length: ");

            double lenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter weight: ");

            double weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a country: ");

            string country = Console.ReadLine();

            Package package = new Package(height, width, lenght, weight, country);

            Console.WriteLine(package.price());

        }


    }
}
