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
            var rand = new Random();
            int n = 100000;
            int[] vect = new int[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = rand.Next(0, 100);
            }
            int somma = 0, 
                max = 0, 
                min = 100;

            foreach (var item in vect)
            {
                somma += item;
                if (min > item)
                {
                    min = item;
                }
                if(max < item)
                {
                    max = item;
                }
                //somma = somma + item;
            }
            double media = (double)somma / n;
            Console.WriteLine($"la somma è {somma}");
            Console.WriteLine($"la media è {media}");
            Console.WriteLine($"il massimo è {max}");
            Console.WriteLine($"la minimo è {min}");
        }
    }
}
