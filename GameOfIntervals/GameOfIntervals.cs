using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double sumNumbers09 = 0;
            double sumNumbers1019 = 0;
            double sumNumbers2029 = 0;
            double sumNumbers3039 = 0;
            double sumNumbers4050 = 0;
            double sumNumbersInvalid = 0;
            double result = 0;

            for (int i = 0; i < count; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number >= 0 && number < 10)
                {
                    result += 0.2 * number;
                    sumNumbers09++;
                }
                else if (number >= 10 && number < 20)
                {
                    result += 0.3 * number;
                    sumNumbers1019++;
                }
                else if (number >= 20 && number < 30)
                {
                    result += 0.4 * number;
                    sumNumbers2029++;
                }
                else if (number >= 30 && number < 40)
                {
                    result += 50;
                    sumNumbers3039++;

                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    sumNumbers4050++;
                }
                else
                {
                    result /= 2;
                    sumNumbersInvalid++;
                }
            }
            Console.WriteLine(result.ToString("f2"));
            Console.WriteLine($"From 0 to 9: {((sumNumbers09/count)*100).ToString("f2")}%");
            Console.WriteLine($"From 10 to 19: {((sumNumbers1019 / count) * 100).ToString("f2")}%");
            Console.WriteLine($"From 20 to 29: {((sumNumbers2029 / count) * 100).ToString("f2")}%");
            Console.WriteLine($"From 30 to 39: {((sumNumbers3039 / count) * 100).ToString("f2")}%");
            Console.WriteLine($"From 40 to 50: {((sumNumbers4050 / count) * 100).ToString("f2")}%");
            Console.WriteLine($"Invalid numbers: {((sumNumbersInvalid / count) * 100).ToString("f2")}%");
        }
    }
}
