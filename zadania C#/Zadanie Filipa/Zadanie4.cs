using System;

class zadanie4
{
    static void Main(string[] args)
    {
        int[] liczby = new int[4];
        int i = 0;
        while (i < 4)
        {
            Console.WriteLine("Podaj liczbę:");
            liczby[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        bool liczbydosprawdzenia = true;
        foreach (int liczba in liczby)
        {
            if (liczba % 2 != 0)
            {
                liczbydosprawdzenia = false;
                break;
            }
        }
        if (liczbydosprawdzenia)
        {
            Console.WriteLine("Tak");
        }
        else
        {
            Console.WriteLine("Nie");
        }
    }
}
