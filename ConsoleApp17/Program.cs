using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp17
{
    class Program
    {
        static void f(int n)
        {
            if (n == 1)
                return 2;
            else
                return 2 * f(n - 1) + 1;
        }

        static void main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
                Console.WriteLine("f({0})={1}", i, f(i));
        }
    }
}
