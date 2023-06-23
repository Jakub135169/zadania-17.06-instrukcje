using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_3_pp_17._06_instrukcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość trójkąta:");
            int wysokosc = int.Parse(Console.ReadLine());

            Console.WriteLine("trójkąt z  '+'");

            for (int i = 1; i <= wysokosc; i++)
            {
             
                int liczbaZnakow = 2 * i - 1;

   
                int liczbaSpacji = wysokosc - i;

     
                for (int j = 0; j < liczbaSpacji; j++)
                {
                    Console.Write(" ");
                }

   
                for (int j = 0; j < liczbaZnakow; j++)
                {
                    Console.Write("+");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
