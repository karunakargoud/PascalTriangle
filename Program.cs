using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int s = 1; s <= n - i - 1; s++)
                {
                    Console.Write(" ");
                }
                int value = 1;
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(value + " ");
                    value = value * (i - j) / (j + 1);

                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
