using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 500;

            x *= ((500 + 1000) / 10) - (30 * 2 ^ 2);

            Console.WriteLine(x);
        }
    }
}
