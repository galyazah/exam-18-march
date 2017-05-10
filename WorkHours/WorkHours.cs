using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int actualHours = 8 * days * workers;
            if (actualHours >= hoursNeeded)
            {
                Console.WriteLine($"{actualHours - hoursNeeded} hours left");
            }
            else
            {
                Console.WriteLine($"{hoursNeeded - actualHours} overtime");
                Console.WriteLine($"Penalties: {(hoursNeeded - actualHours) * days}");
Console.WriteLine("Making changes in both master and develop branches.");            }
        }
    }
}
