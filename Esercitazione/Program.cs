using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    class Program
    {
        /*
Fare un programma che chieda all'utente N numeri diversi e poi ne calcoli la media,
con N letto da tastiera;
 */
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero N");
            int n = int.Parse(Console.ReadLine());
            int somma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("inserisci un numero");
                somma += Convert.ToInt32(Console.ReadLine());
            }

            double media = (double)somma / n;
            Console.WriteLine($"La media dei {n} numeri inseriti è {media}");
        }
    }
}
