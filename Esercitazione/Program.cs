using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Calcolare la somma di tutti i numeri interi compresi 
 fra due valori positivi dati in input a e b.
 */
namespace Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            //leggo il primo numero
            Console.WriteLine("Inserire un numero positivo");
            string line = Console.ReadLine();
            int a = Convert.ToInt32(line);
            //leggo il secondo numero
            Console.WriteLine("Inserire un altro numero positivo");
            int b = int.Parse(Console.ReadLine());

            int somma = 0;
            //bool aMinoreUgualeB = a <= b;
            //var estremoSuperiore = aMinoreUgualeB ? b : a;
            //for (int i = aMinoreUgualeB ? a : b; i < estremoSuperiore; i++)
            //{
            //    somma = somma + i;
            //}

            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    somma = somma + i;
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    somma = somma + i;
                }
            }
            Console.WriteLine($"La somma dei numeri da {a} a {b} è {somma}");
        }
    }
}
