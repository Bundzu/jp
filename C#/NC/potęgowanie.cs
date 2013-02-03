using System;

namespace ConsoleApplication1{
class Program{
    static int potega (int podstawa, int wykladnik) {
        int wynik =podstawa;
        for (int i =1 ; i< wykladnik; i++){
        wynik = wynik * podstawa;
        }
        return wynik;
    }
    
    static void Main(string[] args) {
        Console.Write("Podaj podstawę: ");
        string tekst = Console.ReadLine();
        int podstawa = int.Parse(tekst);
        
        Console.Write("Podaj wykładnik: ");
        string tekst1 = Console.ReadLine();
        int wykladnik = int.Parse(tekst1);
        
        Console.WriteLine("Wynik: " + potega(podstawa,wykladnik));
        }
    }
}
