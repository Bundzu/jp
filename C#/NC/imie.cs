using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){
        Console.WriteLine("Podaj imię");
        string imie = Console.ReadLine();
        if (imie.EndsWith("a")) {
            Console.WriteLine("kobieta");
            }
            else
                Console.WriteLine("mężczyzna");
        
        }
    }
}
