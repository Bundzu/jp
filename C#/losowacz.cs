using System;

namespace Tibia{
    class Program{ // ten program ma nam wylosować 6 liczb z zakresu od 1 do 50 (był pokazany na wykładach), liczby nie mogą się powtarzać, 
                   // nie chciało mi śię dawać układania liczb ponieważ i tak za długo mi zajęło debugowanie kodu z tablicy
        static void losuj (int [] tab){  // tworzymy funkcję losuj (losuje nam liczby)
        
        int los;                         // tworzymy zmienne które potem wykorzystamy 
        bool sprawdzajDalej; 
        Random losowacz = new Random ();
        
        for (int i = 0; i < 6; i++ ){    // pętla for wykona się 6 razy za każdym razem losująć nam nową liczbę
            sprawdzajDalej = false;              
               do {                             // pętla do while będzie losować liczbę którą umieści w tablicy "tab"
               los = losowacz.Next(49)+1 ;      // losowanie liczby z zakresu 1-50
                   for (int j = 0; j < i; j++){ // ta pętla sprawdza nam czy wylosowana liczba znajduje się już w tablicy
                       if (los == tab [j]) {    // jeżeli to prawda to
                       sprawdzajDalej = true;   // będzie losowana nowa liczba w miejscu starej
                       }
                           else sprawdzajDalej = false;  // w przeciwnym razie nie będzie losowania i pętla do whlie (ta nad for) będzie losowała liczbę 
                                                         // dla następnej pozycji w tablicy
                   }
               }while (sprawdzajDalej);         // pętla wykonuje się gdy zmienna "sprawdzajDalej" będzie równa true
           tab[i] = los;                        // gdy liczba spełni wszystkie wymagania zostaje przypisana do tablicy
        }                                // koniec pętli for       
        }                                // koniec funkcji "losowacz"

        static void wyswietl (int [] tab) {  // ta funkcja wypisuje nam wszystkie liczby z tablicy "tab"
            foreach (int el in tab){         // dla kaðego elementu tablicy "tab"
            Console.WriteLine(el);           // zostanie wyświetlona liczba
            }                                // koniec pętli foreach
        }                                    // koniec funkcji "wyswietl"

        static void Main(string[] args){     // funkcja "Main"
        int [] tab = new int [6];            // tworzymy tablicę sześcioelementową z której korzystamy powyżej

        losuj (tab);                         // losujemy liczby
        wyswietl (tab);                      // i wyświetlamy je
        }                                    // koniec funkcji "Main" 
    }
}
