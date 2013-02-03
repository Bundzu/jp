using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){
        Console.WriteLine("Podaj pesel");
        string pesel = Console.ReadLine();
        Console.WriteLine ("dzień: " + pesel.Substring(4, 2));
        Console.WriteLine ("miesiąc: " + pesel.Substring(2, 2));
        Console.WriteLine ("rok: " + pesel.Substring(0, 2));
        }
    }
}
