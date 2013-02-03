using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){ // W tym programie podajemy numer PESEL a program odczytuje nam datę urodzenia
        Console.WriteLine("Podaj pesel"); // Wypisanie polenia dla użyszkodnika
        string pesel = Console.ReadLine(); // Tworzymy zmienną string (ciąg znaków) o nazwie pesel
        Console.WriteLine ("dzień: " + pesel.Substring(4, 2));   // podajemy rok: .Substring wycina nam 2 znaki po pierwszych 4 cyfrach
        Console.WriteLine ("miesiąc: " + pesel.Substring(2, 2)); // podobnie jak powyżej, pierwsza cyfra określa nam położenie a druga długość 
        Console.WriteLine ("rok: " + pesel.Substring(0, 2));     // Pamiętajcie że liczymy w tym przypadku od zera
        }
    }
}
