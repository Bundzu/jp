using System;
namespace Tibia {
    class Program {
        static int silnia (int n) {
        int wynik = 1;
        for (int i =1;i<=n;i++) {
            wynik *=i;
            }
        return wynik;
        }
        
        static int silniar (int n) {
        if (n == 0)
            return 1;
            else
            return n * silniar (n-1);
        }
        
        static void Main(string[] args) {
        Console.WriteLine ("Podaj liczbę: ");
        string liczba = Console.ReadLine();
        int n = int.Parse(liczba);
        
        Console.WriteLine("Wynik przy zastosowaniu zwykłej funkcji:" + silnia(n));
        
        Console.WriteLine("Wynik przy użyciu funkcji silniar: " + silniar(n));
        }
    }
}

