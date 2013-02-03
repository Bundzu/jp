using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){
        int liczba = 1;
        string imie = "a";
        for(int i = 1 ; i<=5 ; i++){
        Console.WriteLine("Napisz imię");
        string tekst = Console.ReadLine();
        int a = tekst.Length;
        if (a > liczba){
           liczba = a;
           imie = tekst;
           }
        }
        Console.WriteLine("Najdłuższe imię to: " + imie + " i ma " + liczba + " znaków.");
        }
   }
}
