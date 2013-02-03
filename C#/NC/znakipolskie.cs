using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){
        Console.WriteLine("napisz coś");
        string tekst = Console.ReadLine();
        tekst = tekst.Replace ("ą", "a");
        tekst = tekst.Replace ("ę", "e");
        tekst = tekst.Replace ("ó", "o");
        tekst = tekst.Replace ("ć", "c");
        tekst = tekst.Replace ("ń", "n");
        tekst = tekst.Replace ("ż", "z");
        tekst = tekst.Replace ("ź", "z");
        tekst = tekst.Replace ("ł", "l");
        Console.WriteLine(tekst);
        }
    }
}
