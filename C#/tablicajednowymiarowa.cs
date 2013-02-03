using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){
        // Teraz stworzymy jednowymiarową tablicę
        int[] tablica = new int[3];  // tworzymy tablicę która mieści 3 elementy, każdy z nich to liczba całkowite (int)
        tablica [0] =2;              // ponieważ każda wartośc nowej tablicy wynosi 0 to przypisujemy do zerowego miejsca cyfrę 2. 
                                     // elementy tablicy są indeksowane (liczone) od cyfry 0
        for (int i =0 ; i< tablica.Length; i++){  // ponieważ tablica jest utworzona to teraz ją odczytamy za pomocą pętli for
                                                  // pętla wykona się 3 razy ponieważ tyle elementów ma tablica (tablica.Length)
            Console.WriteLine(tablica[i]);        // wypisujemy wystkie elementy
        }                                         // koniec pętli
        }
    }
}
