using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            x += 5; // то же самое, что x = x + 5
            Console.WriteLine($"x после x += 5: {x}"); // 15
        }
    }
}

