using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 5;
            Console.WriteLine(x == y);
            object a = 5, b = 5;
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

            Console.ReadKey();
        }
    }
}
