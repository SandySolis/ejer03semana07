using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer03semana07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año1 = 1900;
            int año2 = 2023; 

            Console.WriteLine("Años bisiestos desde " + año1 + " hasta " + año2 + ":");

            for (int i = año1; i <= año2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("- " + i);
                }
            }
            Console.ReadKey();
        }
    }
}

