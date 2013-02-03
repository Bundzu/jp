using System;
namespace Tibia {
    class Program {
    // Prosta funkcja rekurencyjna: ciąg fibonacciego
    // jeżeli nie wiesz co to jest rekurecja ani ciąg fibonacciego to wejdź w te linki:
    // http://pl.wikipedia.org/wiki/Ci%C4%85g_Fibonacciego
    // http://pl.wikipedia.org/wiki/Rekurencja
    // W angielskiej wiki będzie więcej informacji
        static int ciag (int x) { // została stworzona funkcja "ciag" która będzie nam wyliczała n'tą
                                  // liczbę w ciągu fibonacciego
        if (x == 0 || x == 1)     // jeżeli liczba całkowita "x" będzie równa 0 lub 1 (ten znaczek "||" oznacza "lub")
            return x;             // to zwraca nam wartość tej liczby bo tak jest w ciągu fibonacciego (dla liczb 0 i 1)
            else                  // w pozostałym przypadku wartość będzie wylliczana z następującego wzoru poniżej
            return x = ciag(x-1) + ciag(x-2); // wartość (x) to suma dwóch porzednich wartości ciągu
        }
// uwaga dużo tekstu dla tych co niezrozumieli
// wartość 0 to 0
// wartość 1 to 1 bo tak napisaliśmy w jedenastej linii  ( if (x == 0 || x == 1)  )
// dlatego wartość drugiej liczby w ciągu fibonacciego (czyli 2)  wyniesie 1 bo to jest suma dwóch poprzednich wartośći
// komputer to zinterpretował jako x = 1 + 0  bo ciag(x-1) = 1 i  ciag(x-2) = 0
// dla liczby 3 wartość ciągu wynosi 2 ponieważ dwie poprzednie liczby to 1 i 1 (x = 1 + 1)
// dla liczby 4 wartość ciągu wynosi 3  (x = 2 + 1)
// dla liczby 5 wartośc ciągu wynosi 5  (x = 3 + 2)
// dla liczby 6 wartość ciągu wynosi 8  (x = 5 + 3)
// dla liczby 7 wartość ciągu wynosi 13 (x = 8 + 5) itd.
// warto zauważyć że za każdym razem funkcja musi się się odwołać do wartości ciągu liczonych z mniejszych liczb 
// a te do poprzedzających je aż do zera

        static void Main(string[] args) {     // funkcja "Main"
        Console.Write("Podaj liczbę: ");      // wypisujemy tekst
        string liczba = Console.ReadLine();   // podajemy zmienną "liczba" która jest tekstem
        int x = int.Parse (liczba);           // zmieniamy ją w liczbę która jest wykorzystana w funkcji powyżej

        Console.WriteLine("Wynik: " + ciag(x) ); // wypisujemy wartość ciągu
        }
    }
}
