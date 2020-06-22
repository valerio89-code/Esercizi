using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Scrivere un programma che stampi a video tutti i numeri pari compresi 
 tra due estremi a e b letti da tastiera. 
Il programma deve dire anche quanti sono.
*/
namespace Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero intero");
            string readLine = Console.ReadLine();
            int a = Convert.ToInt32(readLine);
            Console.WriteLine("inserisci un altro numero intero");
            readLine = Console.ReadLine();
            int b = Convert.ToInt32(readLine);
            if(a<b)
            {
                //se a è minore di b
                int contatore = 0;
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " è un numero pari");
                        contatore++;
                    }
                }

                Console.WriteLine($"il totale dei numeri pari compresi tra {a} e {b} è " + contatore);
            }
            else //ALTRIMENTI (a maggiore di b e a = b)
            {
                Console.WriteLine("Errore: a maggiore di b");
            }

            

            Console.ReadLine();
        }
    }
}
