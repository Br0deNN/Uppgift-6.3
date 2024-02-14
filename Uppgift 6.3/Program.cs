using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Addera tre tal");
        Console.WriteLine("2. Största talet av två tal");
        Console.WriteLine("3. Avsluta programmet");
        int nummer = int.Parse(Console.ReadLine());
        switch (nummer)
        {
            case 1:
                Console.WriteLine("Skriv in tre tal");
                Console.WriteLine("Skriv in tal 1");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in tal 2");
                int tal2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in tal 3");
                int tal3 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Summan av talen blir {Addera(tal1, tal2, tal3)}");
                break;

            case 2:
                Console.WriteLine("Skriv in två tal");
                Console.WriteLine("Skriv in ett tal");
                int talx = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in ett till tal");
                int taly = int.Parse(Console.ReadLine());
                Console.WriteLine($"Det största talet är {Störst(talx, taly)}");
                break;

            case 3:
                Console.WriteLine("Avslutar programmet...");
                break;
        }
        
    }

    static int Addera(int tal1, int tal2, int tal3)
    {
        return tal1 + tal2 + tal3;

    }
    static int Störst(int talx, int taly)
    {
        if (talx > taly)
        {
            return talx;
        }
        else
        {
            return taly;
        }
    }
}