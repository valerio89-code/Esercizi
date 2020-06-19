using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool pinCorretto = true;
            do
            {
                Console.WriteLine("Inserire il pin");
                string pin = Console.ReadLine();
                pinCorretto = VerificaPin(pin);
            } while (pinCorretto == false);

            pinCorretto = true;
            while (!pinCorretto)
            {
                Console.WriteLine("Inserire il pin");
                string pin = Console.ReadLine();
                pinCorretto = VerificaPin(pin);
            }

            Console.WriteLine("Complimneti, accesso avvenuto");
            Console.ReadLine();
        }

        public static bool VerificaPin(string testPin)
        {
            if (testPin == "1234")
            {
                Console.WriteLine("Pin corretto inserito");
                return true;
            }
            Console.WriteLine("Pin inserito non corretto");
            return false;            
        }
        public static string CheckConnection(string connResponse)
        {
            switch (connResponse)
            {
                case "404":
                    Console.WriteLine("Not found");
                    return "errore 404";
                case "503":
                    Console.WriteLine("Internal server error");
                    break;
                case "200":
                    Console.WriteLine("OK");
                    break;
                default:
                    Console.WriteLine("errore di connessione generico");
                    break;
            }
            //qualsiasi cosa
            Console.WriteLine("end of switch (internal method)");
            return "end of switch";
        }

        public static void GetAnimal(Animal animal)
        {
            var castedVariable = animal as Leone;
            Console.WriteLine(castedVariable.GetVerso());
            Console.WriteLine(animal.GetType());
        }
        public class Animal
        {
            public int GetAge()
            {
                return 89;
            }

        }

        public class Elefante : Animal
        {

        }

        public class Leone : Animal
        {
            public string GetVerso()
            {
                return "RUGGITO";
            }
        }
    }
}
