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
            string[][] classi = new string[3][];
            for (int i = 0; i < classi.Length; i++)
            {
                Console.WriteLine($"Quanti studenti ci sono nella classe {i}?");
                int numStudenti = int.Parse(Console.ReadLine());
                classi[i] = new string[numStudenti];
                for (int j = 0; j < numStudenti; j++)
                {
                    Console.WriteLine("inserisci il nome di un alunno");
                    classi[i][j] = Console.ReadLine();
                }

                Array.Sort(classi[i]);
            }
            Console.Clear();
            for (int i = 0; i < classi.Length; i++)
            {
                Console.WriteLine($"Nella classe {i} ci sono {classi[i].Length} studenti e sono:");
                for (int j = 0; i < classi[i].Length; j++)
                {
                    Console.WriteLine(classi[i][j]);
                }
            }
        }
    }
}
