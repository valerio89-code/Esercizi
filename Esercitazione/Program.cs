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
        /*
Scrivere un programma che chieda all'utente un numero intero qualsiasi
finchè l'utente inserisce il 99. a quel punto deve uscire.
Per ogni iterazione, stampare il massimo numero che si è scritto fino 
a quel momento.
 */
        static void Main(string[] args)
        {
            int n = 0;
            int max = 0;
            while (n != 99)
            {
                Console.WriteLine("inserire un numero intero");
                n = int.Parse(Console.ReadLine());
                if (n > max)
                {
                    //ho trovato un nuovo massimo
                    max = n;
                }
                Console.WriteLine($"il numero massimo inserito finora è: {max}");
            }
            Console.WriteLine("È stato inserito il numero 99");
        }
    }
}
