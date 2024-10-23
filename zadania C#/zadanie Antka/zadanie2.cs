using System;

class zadanie2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do sprawdzenia:");
            string tekst = Console.ReadLine();

            Console.WriteLine("Podaj literę do sprawdzenia:");
            char litera = Console.ReadKey().KeyChar;
            
               
            
            var liczba = 0;
            foreach (char litera2 in tekst)
            { if (litera2 == litera)
                {
                    liczba++;
                }
            }

            Console.WriteLine($"\n\nLitera  {litera}  występuje {liczba} razy w podanym tekście.");
            Console.ReadLine();
        }
    }
