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

            bool running = true;

            while (running)
            {
                Console.WriteLine("Välkommen till huvudmenyn!\n" +
                                  "Navigera genom att ange den siffra som motsvarar menyvalet - avsluta med <Enter>.\n\n" +
                                  "0 - Programmet stängs\n" +
                                  "1 - Bioprisuträknare\n" +
                                  "2 - Ej implementerat");


                int choice = 0;

                // Keep trying to input answer until getting a valid number, an integer 
                while (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Det du angav var inte en siffra, försok igen");


                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Stänger ner programmet");
                        running = false;
                        break;
                   
                    default:
                        Console.WriteLine("Du har angivet ett felaktig menyval");
                        break;



                }
            }
        }
    }
}
