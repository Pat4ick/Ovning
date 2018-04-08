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
                Console.Clear();
                Console.WriteLine("\n**************************\n" +
                                  "Välkommen till huvudmenyn!\n" +
                                  "Navigera genom att ange den siffra som motsvarar menyvalet - avsluta med <Enter>.\n\n" +
                                  "0 - Programmet stängs\n" +
                                  "1 - Bioprisuträknare\n" +
                                  "2 - Ej implementerat");

                // Keep trying to input answer until getting a valid number, an integer 
                int choice = RequestInt();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Stänger ner programmet");
                        running = false;
                        PauseForKeyPress();
                        break;
                    case 1:
                        Console.WriteLine("Priskalkylator för biobesök\n" +
                                          "Vänligen uppge din ålder:\n");
                        int age = RequestInt();

                        if(age < 20)
                        {
                            Console.WriteLine("Ungdomspris 80kr");
                        }
                        else if(age > 64)
                        {
                            Console.WriteLine("Pensionärspris 90kr");
                        }
                        else
                        {
                            Console.WriteLine("Standardpris 120kr");
                        }
                        PauseForKeyPress();
                        

                        break;
                    case 2:
                        Console.WriteLine("Uppepa tio gånger\n" +
                                          "Ange en text som du vill få upprepad tio gånger:\n");
                        string text 

                    default:
                        Console.WriteLine("Du har angivet ett felaktig menyval");
                        PauseForKeyPress();
                        break;



                }
            }
        }

        private static int RequestInt()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Det du angav var inte en siffra, försok igen");
            return number;
        }

        private static void PauseForKeyPress()
        {
            Console.WriteLine("\nTryck någon knapp för att fortsätta");
            Console.ReadKey();
        }
    }
}
