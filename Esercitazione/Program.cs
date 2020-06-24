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
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2;
            //copiare i valori dell'array arr nell'array arr2
            arr2 = new int[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i]; 
            }
            arr[0] = 98;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"l'elemento {i} di arr vale {arr[i]}");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"l'elemento {i} di arr2 vale {arr2[i]}");
            }

        }
    }
}
