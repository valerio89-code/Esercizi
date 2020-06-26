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
        Dobbiamo creare un programma che stampi i nomi
        degli studenti di ogni classe di un istituto con 3 classi.
        Ogni classe ha un numero diverso di studenti,
        quindi deve chiedere preliminarmente per ogni classe,
        quanti studenti ci sono e solo dopo chiederne i nomi.

        */
        static void Main(string[] args)
        {
            string[] test = new string[] { "A", "C", "S", "B" };
            foreach (var str in test)
            {
                Console.WriteLine(str);
            }
            Array.Sort(test);
            foreach (var str in test)
            {
                Console.WriteLine(str);
            }
            return;
        }
    }
}
