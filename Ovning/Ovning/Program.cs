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
                                  "2 - Upprepa text\n" +
                                  "3 - Tredje ordet\n");

                // Keep trying to input answer until getting a valid number, an integer 
                int choice = RequestInt();

                // Main menu
                switch (choice)
                {
                    case 0: // Exit the program
                        Console.WriteLine("Stänger ner programmet");
                        running = false;
                        PauseForKeyPress(); // pausing
                        break;
                    case 1: // Calculates ticket prices
                        Console.WriteLine("Priskalkylator för biobesök\n" +
                                          "Vänligen uppge din ålder:\n");
                        int age = RequestInt(); // validated user input (only an integer response accepted)
                        if (age < 5){
                            Console.WriteLine("Barn under 5 - gratis.");
                        }

                        if(age < 20)
                        {
                            Console.WriteLine("Ungdomspris 80kr");
                        }
                        else if(age > 64 && age < 100)
                        {
                            Console.WriteLine("Pensionärspris 90kr");
                        }
                        else if(age > 100)
                        {
                            Console.WriteLine("Pris för äldre pensionärer - gratis");
                        }
                        else
                        {
                            Console.WriteLine("Standardpris 120kr");
                        }
                        PauseForKeyPress();
                        
                        break;

                    case 2: // Repeat entered text ten times
                        Console.WriteLine("Uppepa tio gånger\n" +
                                          "Ange en text som du vill få upprepad tio gånger:\n");
                        string text = Console.ReadLine();
                        for (int i = 1; i < 11; i++  ){
                            Console.Write($"{i}.{text} ");
                        }
                        PauseForKeyPress(); 
                        break;

                    case 3: // Prints out the third word in a sentence
                        Console.WriteLine("Tredje ordet\n" +
                                          "Ange en mening med minst tre ord:\n");
                        text = RequestSentence(); // validated user input
                        string[] words = text.Split(' ');
                        Console.WriteLine($"Ord nummer tre är {words[2]}");
                        PauseForKeyPress();
                        break;


                    default: // Default response
                        Console.WriteLine("Du har angivet ett felaktig menyval");
                        PauseForKeyPress();
                        break;

                    

                }
            }
        }

        // Validate input (only an integer response accepted)
        private static int RequestInt()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Det du angav var inte en siffra, försök igen");
            return number;
        }

        // Validate input (accept only a sentence with at least 3 words)
        private static string RequestSentence()
        {
            string text;
            // simultanously read the input string, count the number of spaces and 
            //repeat if not finding at least 2 -> at least three words
            while (((text = Console.ReadLine()).Count(letter => letter == ' ') < 2))
            {
                Console.WriteLine($"Texten innehåller för få ord, minst tre ord tack.");
                PauseForKeyPress();
            }

            return text;
        }

        // Helper method for pausing the program to give the user time to read previous output
        private static void PauseForKeyPress()
        {
            Console.WriteLine("\nTryck någon knapp för att fortsätta");
            Console.ReadKey();
        }
    }
}
