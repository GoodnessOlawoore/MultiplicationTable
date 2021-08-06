using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication Table 1 - 12
            Console.WriteLine("Multiplication Table 1 - 12:\n");
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
