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

            int[] vectInverso = new int[n];
            for (int i = 0; i <= n-1; i++)
            {
                vectInverso[n - 1 - i] = vect[i];
            }

            Console.WriteLine("il vettore invertito è");
            foreach (var item in vectInverso)
            {
                Console.WriteLine(item);
            }

        }
    }
}
