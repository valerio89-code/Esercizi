using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*Inserire un numero da tastiera val. 
    Il programma a questo punto deve chiedere all’utente di inserire un altro numero n e 
    verificare se è maggiore di val o è minore di val.*/
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 10;
            p.Y = 11;
            Console.WriteLine("Coordinate punto P : " + p);

            Point p2 = new Point();
            p2 = p;
            Console.WriteLine("Coordinate punto P2 : " + p2);
            p.X = 12;

            Console.WriteLine("Coordinate punto P : " + p);
            Console.WriteLine("Coordinate punto P2 : " + p2);
            Console.ReadLine();


            TaskType newTask = TaskType.RiparazioneComputer;

            switch (newTask)
            {
                case TaskType.InstallazioneSO:
                    Console.WriteLine("Installazione SO");
                    break;
                case TaskType.RiparazioneComputer:
                    Console.WriteLine("Riparazione PC");
                    break;
            }
                                  
            Console.WriteLine();
        }

        public enum TaskType
        {
            RiparazioneComputer,
            InstallazioneSO,
            SostituzioneDisco 
        }

        public struct Point
        {
            public float X;
            public float Y;
            public override string ToString()
            {
                return $"X = {X}, Y = {Y}";
            }
        }

    }
}
