using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){  // zrobimy 2 tablice dwuwymiarowe (każda innym sposobem)
        int [,] tablica = new int [4,5];  // tworzymy tablicę o 4 wierszach i 5 kolumnach
        tablica [1,1] = 7;                // przypisujemy liczbę 7 aby tablica nie była smutna
        for (int y = 0; y < 4 ; y++){     // teraz odczytujemy ją za pomocą pętli for, ta pętla odczyna nam igreki (wiersze)
            for (int x = 0; x <5; x++){   // a ta iksy (kolumny)
                Console.Write (tablica [y,x]);  // tutaj wypisujemy wszystkie elementy
                }                               // koniec pętli
            Console.WriteLine ();         // po wyświetleniu każdego wiersza tworzona jest nowa linia po to aby tablica była czytelniejsza
            }                             // koniec pętli
        
        Console.WriteLine ();             // następna linia 

        int [][] tablicax = new int [6] [];        // drugi sposób na tablicę, tym razem podajemy tylko liczbę wierszy
        for (int i = 0; i< tablicax.Length; i++){  // do każdego wiersza będą dopisywane kolumny
            tablicax [i] = new int [8];            // tym razem będzie to 8 kolumn
        }                                          // koniec tworzenia tablicy, teraz możemy ją odczytać
        for (int z = 0; z < tablicax.Length; z++){        // pętla będzie odczytywać nam zawartość tablicy, najpierw wiersze
            for (int a = 0; a< tablicax[z].Length; a++){  // a teraz kolumny
               Console.Write (tablicax [z][a]);           // wypisanie elementów tablicy
               }                                          // koniec pętli
               Console.WriteLine ();                      // dodawanie po każdym wierszu następnej linii
           }                                              // koniec pętli

        }
    }
}
