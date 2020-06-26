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
Scrivere un programma che crei un vettore di 100 interi 
contenente numeri casuali compresi tra 1-100.
Successivamente il programma chiede all’utente di inserire 
un numero compreso tra 1-100 e ricerca tale numero
nel vettore.
Per ogni occorrenza stampa la posizione in cui è stato 
trovato e alla fine della ricerca riporta
anche il numero di elementi trovati.


        */
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] vect = new int[100];
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = rand.Next(0, 10);
            }

            Console.WriteLine("Inserisci un numero da cercare nel vettore");
            int numScelto = int.Parse(Console.ReadLine());

            int occorrenzeNumScelto = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                if(vect[i] == numScelto)
                {
                    Console.WriteLine($"numero {numScelto} trovato in posizione {i}");
                    occorrenzeNumScelto++;
                }
            }
            Console.WriteLine($"Il numero {numScelto} è stato trovato {occorrenzeNumScelto} volte");
        }
    }
}
