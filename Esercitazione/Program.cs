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
Due colleghi intendono fissare una riunione, pertanto devono 
identificare dei giorni nei quali sono entrambi liberi da 
impegni. A tale scopo, essi realizzano un programma che 
permetta a ciascuno di immettere le proprie disponibilità, e
che identifichi i giorni nei quali entrambi sono liberi. 
(ipotizzare che i giorni siano interi)

        */
        static void Main(string[] args)
        {
            const int dimMese = 31;
            int[] dispV = new int[dimMese];
            int[] dispA = new int[dimMese];
            for (int i = 0; i < dimMese; i++)
            {
                Console.WriteLine("Valerio, hai altre disponibilità?");
                string disp = Console.ReadLine();
                if (disp == "no")
                {
                    break;
                }
                else
                {
                    dispV[i] = int.Parse(disp);
                }
            }

            for (int i = 0; i < dimMese; i++)
            {
                Console.WriteLine("Andrea, hai altre disponibilità?");
                string disp = Console.ReadLine();
                if (disp == "no")
                {
                    break;
                }
                else
                {
                    dispA[i] = int.Parse(disp);
                }
            }

            for (int i = 0; i < dispV.Length; i++)
            {
                if (dispV[i] == 0) break;

                for (int j = 0; j < dispA.Length; j++)
                {
                    if (dispA[j] == 0) break;
                    if (dispV[i] == dispA[j])
                    {
                        Console.WriteLine(dispV[i]);
                    }
                }
            }

       



        }
    }
}
