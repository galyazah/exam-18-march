using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniLogo
{
    class SoftuniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int middleCharp = 1;
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', (12 * n - 5 - middleCharp) / 2));
                Console.Write(new string('#', middleCharp));
                Console.WriteLine(new string('.', (12 * n - 5 - middleCharp) / 2));
                middleCharp += 6;
            }

            middleCharp -= 12;
            for (int i = 0; i < n - 2; i++)
            {
            Console.Write('|');
            Console.Write((new string('.', (12 * n - 5 - middleCharp) / 2 - 1)));
            Console.Write(new string('#', middleCharp));
            Console.WriteLine(new string('.', (12 * n - 5 - middleCharp) / 2));
            middleCharp -= 6;
            }
            for (int i = 0; i < n - 1; i++)
            {
            Console.Write('|');
            Console.Write((new string('.', (12 * n - 5 - middleCharp) / 2 - 1)));
            Console.Write(new string('#', middleCharp));
            Console.WriteLine(new string('.', (12 * n - 5 - middleCharp) / 2));
            }
            Console.Write('@');
            Console.Write((new string('.', (12 * n - 5 - middleCharp) / 2 - 1)));
            Console.Write(new string('#', middleCharp));
            Console.WriteLine(new string('.', (12 * n - 5 - middleCharp) / 2));
        }
    }
}
