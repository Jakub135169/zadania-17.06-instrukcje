using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_1_pp_17._06_instrukcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Podaj liczbę n:");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"Pierwsze {n} liczb:");

                int liczba = 2; 

                while (n > 0)
                {
                    bool czyPierwsza = true;

                    if (liczba < 2)
                        czyPierwsza = false;

                    for (int i = 2; i * i <= liczba; i++)
                    {
                        if (liczba % i == 0)
                        {
                            czyPierwsza = false;
                            break;
                        }
                    }

                    if (czyPierwsza)
                    {
                        Console.WriteLine(liczba);
                        n--;
                    }

                    liczba++;
                }

                Console.ReadKey();
            }
        }

    }

