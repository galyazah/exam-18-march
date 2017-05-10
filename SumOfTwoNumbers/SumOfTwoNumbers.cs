using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool noCombination = true;
            int i;
            int r;

            for (i = startNumber; i <= endNumber; i++)
            {
                for (r = startNumber; r <= endNumber; r++)
                {
                    combination++;
                    if (i + r == magicNumber)
                    {
                        noCombination = false;
                        Console.WriteLine($"Combination N:{combination} ({i} + {r} = {magicNumber})");
                        break;
                    }
                    
                }
                if (noCombination == false)
                {
                    break;
                }
            }
                if (noCombination)
                {
                    Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
                }
            }
    }
}
