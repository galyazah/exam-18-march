using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class RentCar
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {(0.35 * budget).ToString("f2")}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(0.65 * budget).ToString("f2")}");
                }
            }
            else if (budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {(0.45 * budget).ToString("f2")}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(0.80 * budget).ToString("f2")}");
                }
            }
            else
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {(0.9 * budget).ToString("f2")}");
            }
        }
    }
}
