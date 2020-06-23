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
Fare un programma che chieda all'utente un numero N e stampi i primi
N numeri della sequenza di fibonacci.
0 1 1 2 3 5 8 13 21 34
 */
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri di fibonacci vuoi vedere?");
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            for (int i = 0; i < n; i++)
            {
                if (i > 1)
                {
                    int f = f2 + f1;
                    f1 = f2;
                    f2 = f;
                    Console.WriteLine(f);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
