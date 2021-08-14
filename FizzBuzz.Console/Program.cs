using LibFizzBuzz;
using System;

namespace ConsoleFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
                Console.Write(Regra.ResolveFizzBuzz(i) + ", ");
        }
    }
}
