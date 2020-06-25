using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la dimensione del vettore");
            int n = int.Parse(Console.ReadLine());
            int[] vect = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserisci la componente {i} del vettore");
                vect[i] = int.Parse(Console.ReadLine());
            }

            bool isCrescente = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (vect[i] >= vect[i + 1])
                {
                    isCrescente = false;
                    break;
                }
            }
            if(isCrescente)
            {
                Console.WriteLine("Il vettore inserito è crescente");
            }

            bool isDecrescente = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (vect[i] <= vect[i + 1])
                {
                    isDecrescente = false;
                    break;
                }
            }
            if (isDecrescente)
            {
                Console.WriteLine("il vettore inserito è decrescente");
            }

            if(!isCrescente && !isDecrescente)
            {
                Console.WriteLine("il vettore non è né crescente né decrescente");
            }
        }
    }
}
