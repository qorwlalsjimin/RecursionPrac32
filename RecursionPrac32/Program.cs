using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPrac32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(50));

            FibonacciAdv ifboAdv = new FibonacciAdv();
            Console.WriteLine(FibonacciAdv.Get(50));
        }
    }
}
