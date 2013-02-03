using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){   // Tutaj wypisujemy coś a program wypisuje nam to samo ale bez polskiech znaków
        Console.WriteLine("napisz coś");   // wypisujemy tekst
        string tekst = Console.ReadLine(); // tworzymy zmienną tekst w którą będziemy coś wpisywać
        tekst = tekst.Replace ("ą", "a");  // za każdym razem kolejny znak zostaje zastąpiony innym
        tekst = tekst.Replace ("ę", "e");
        tekst = tekst.Replace ("ó", "o");
        tekst = tekst.Replace ("ć", "c");
        tekst = tekst.Replace ("ń", "n");
        tekst = tekst.Replace ("ż", "z");
        tekst = tekst.Replace ("ź", "z");
        tekst = tekst.Replace ("ł", "l");
        Console.WriteLine(tekst);          // Wypisujemy zmnieniony tekst (bez polskiech znaków)
        }
    }
}
