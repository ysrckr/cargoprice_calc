using System;
using System.Collections.Generic;
using System.Text;

namespace cargo_price_calc
{
    class Package
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }

        public double Weight { get; set; }

        public double Desi { get; set; }

        public string Country { get; set; }

        public Package(double height, double width, double lenght, double weight, string country)
        {
            Height = height;
            Width = width;
            Lenght = lenght;
            Weight = weight;
            Desi = (Height * Width * Lenght) / 5000;
            Country = country;

        }

        public double price()
        {
            if (Desi > Weight)
            {
                Console.WriteLine($"Package's dimensional weight {Desi} is higher than weight {Weight}. Calculation is going to be made by using dimensional weight.");
                switch (Country)
                {
                    case "abd":
                        Console.WriteLine("Total price is(EUR) ");
                        return Desi * 30;
                    case "almanya":
                        Console.WriteLine("Total price is(EUR) ");
                        return Desi * 20;
                    case "nigerya":
                        Console.WriteLine("Total price is(EUR) ");
                        return Desi * 40;
                    default:
                        Console.WriteLine("You've enter an unknown country. Price is calculated with the highest rate.");
                        Console.WriteLine("Total price is(EUR) ");
                        return Desi * 50;
                }
            }
            else
            {
                Console.WriteLine($"Package's weight {Weight} is higher than dimensional weight {Desi}. Calculation is going to be made by using weight.");
                switch (Country)
                {
                    case "abd":
                        Console.WriteLine("Total price is(EUR) ");
                        return Weight * 30;
                    case "almanya":
                        Console.WriteLine("Total price is(EUR) ");
                        return Weight * 20;
                    case "nigerya":
                        Console.WriteLine("Total price is(EUR) ");
                        return Weight * 40;
                    default:
                        Console.WriteLine("You've enter an unknown country. Price is calculated with the highest rate.");
                        Console.WriteLine("Total price is(EUR) ");
                        return Weight * 50;
                }
            }

        }
    }
}
