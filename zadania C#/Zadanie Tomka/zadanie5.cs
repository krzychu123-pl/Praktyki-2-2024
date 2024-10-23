using System;

class zadanie5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierszą liczbę:");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę:");
        double liczba3 = Convert.ToDouble(Console.ReadLine());

        double suma = liczba1 + liczba2 + liczba3;

        if (suma % 3 == 0)
        {
            Console.WriteLine("\nSuma trzech liczb wynosi " + suma + " i reszta z dzielenia jest równa 0");
        }
        else
        {
            Console.WriteLine("\nSuma trzech liczb wynosi " + suma + " i reszta z dzielenia nie jest równa 0");
        }
        Console.WriteLine("\n\nKliknij aby zakończyć");
        Console.ReadKey();
    }
    }