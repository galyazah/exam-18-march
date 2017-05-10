using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double wallsArea = 2 * A * A / 2 + 2 * (A / 2) * (A / 2) + (A / 2) * (B - A / 2) - (A / 5) * (A / 5);
            double roofArea = 2 * (A * A / 2);
            double greenPaint = wallsArea / 3;
            double redPaint = roofArea / 5;
            Console.WriteLine(greenPaint.ToString("f2"));
            Console.WriteLine(redPaint.ToString("f2"));
        }
    }
}
