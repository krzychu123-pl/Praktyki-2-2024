using System;

class Zadanie1
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Wprowadź pierwszą liczbę:");
                var zmienna1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wprowadź drugą liczbę:");
                var zmienna2 = Convert.ToDouble(Console.ReadLine());

                var suma = zmienna1 + zmienna2;
                var odejmowanie = zmienna1 - zmienna2;
                var mnozenie = zmienna1 * zmienna2;
                var dzielenie = (zmienna2 != 0) ? zmienna1 / zmienna2 : 0;

                Console.WriteLine("\n\nWynik sumy: " + suma);
                Console.WriteLine("Wynik odejmowania: " + odejmowanie);
                Console.WriteLine("Wynik mnożenia: " + mnozenie);

                if (zmienna2 != 0)
                {
                    Console.WriteLine("Wynik dzielenia: " + dzielenie);
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez 0");
                }

                Console.WriteLine("\n\nNaciśnij dowolny przycisk, aby zakończyć...");
                Console.ReadKey();
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadzono niepoprawne dane, proszę podać liczbę! \n\n");
            }
        }
    }
}
