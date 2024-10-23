using System;

class zadanie3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę do sprawdzenia:");
        var liczba = Convert.ToDouble(Console.ReadLine());
        
        if (liczba != 0)
        {
            if (liczba > 0)
            {
                Console.WriteLine("Liczba jest dodatnia");
            }
            else { Console.WriteLine("Liczba jest ujemna"); }
        }
            else{
                Console.WriteLine("Liczba jest zerem");
            }
        }
}
