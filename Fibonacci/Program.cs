using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, F0 = 0, F1 = 1, F;

            while (n >= 0)
            {
                F = F0 + F1;
                Console.WriteLine(F);
                n++;
                F0 = F1;
                F1 = F;
            }
        }
    }
}
