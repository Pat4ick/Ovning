using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Välkommen till huvudmenyn!\n" +
                              "Navigera genom att ange den siffra som motsvarar menyvalet - avsluta med <Enter>.\n\n" +
                              "0 - Programmet stängs\n" +
                              "1 - Evig loop\n" +
                              "2 - Ej implementerat");

            bool isANumber = false;
            int choice = 0;

            do
            {
                isANumber = int.TryParse(Console.ReadLine(), out choice);

            } while (!isANumber);



            switch (choice)
            {
                case 0:
                    Console.WriteLine("Stänger ner programmet");
                    break;
                default:
                    Console.WriteLine("Du har angivet ett felaktig menyval");
                    break;
    


            }

        }
    }
}
