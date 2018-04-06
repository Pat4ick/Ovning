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
                              "Navigera genom att ange den siffra som motsvarar menyvalet.\n\n" +
                              "0 - Programmet stängs\n" +
                              "1 - Evig loop\n" +
                              "2 - Ej implementerat");

            bool correctlyFormatted = int.TryParse(Console.ReadLine(), out int choice);



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
