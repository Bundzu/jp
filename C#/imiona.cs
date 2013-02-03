using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){   // Ten program wybiera najdłuższe imię z pięciu wpisanych, jest to coś podobnego do minmax.cs znajdującego się na moim gitku
        int liczba = 1;                    // musimy mieć zmienną liczba aby ją porównywać z liczbą znaków
        string imie = "a";                 // podobnie jak powyżej tylko że dla imion
        for(int i = 1 ; i<=5 ; i++){       // Pętla for: wykona się 5 razy
        Console.WriteLine("Napisz imię");  // wypisanie tekstu
        string tekst = Console.ReadLine(); // zmienna "teks"t będzie naszym imieniem 
        int a = tekst.Length;              // tworzymy zmienną "a" która wynosi tyle ile ma znaków zmienna "tekst"
        if (a > liczba){                   // jeżeli liczba znaków (zmienna a) jest większa od zmiennej "liczba" to staje się nią. Oraz:
           liczba = a;                     
           imie = tekst;                   // zmienna "imię" zostaje zastąpiona przez zmienną "tekst"
           }                               // koniec pętli. Jeżeli najdłużym imieniem było imię "Seba" to zmienna "liczba" będzie się równała 4
                                           // oraz zmienna tekstowa "imie" będzie wynosiła "Seba"
        }
        Console.WriteLine("Najdłuższe imię to: " + imie + " i ma " + liczba + " znaków."); // Program wypisuje nam imię i ile ma znaków.
        }
   }
}
