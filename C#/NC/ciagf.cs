using System;
namespace Tibia {
    class Program {
        static int ciag (int x) {
        if (x == 0 || x == 1)
            return x;
            else
            return x = ciag(x-1)+ciag(x-2);
        }

        static void Main(string[] args) {
        Console.Write("Podaj liczbę: ");
        string liczba = Console.ReadLine();
        int x = int.Parse (liczba);
        
        Console.WriteLine("Wynik: " + ciag(x) );
        }
    }
}
