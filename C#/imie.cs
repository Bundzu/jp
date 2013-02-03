using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){  // Program ten określa czy imię jest żeńskie czy męskie (uwaga myli się w przypadku takich imion jak Seba czy Kuba)
        Console.WriteLine("Podaj imię");  // wypisanie tekstu
        string imie = Console.ReadLine(); // Tworzymy zmienną "imie" w której wpiszemy imię
        if (imie.EndsWith("a")) {         // Jeżeli imię kończy się na literkę "a" to imię należy do kobiety
            Console.WriteLine("kobieta");
            }
            else                          // w przeciwnym razie
                Console.WriteLine("mężczyzna"); // należy do mężczyzny        
        }
    }
}
