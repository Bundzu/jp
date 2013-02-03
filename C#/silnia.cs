using System;
namespace Tibia {
    class Program {

        // tutaj obliczmy slinię z podanej liczby za pomocą dwóch funkcji: iteracyjnej (silnia) i rekursywnej (silniar)
        // (chyba) lepiej wytłumaczona rekurencja została na przykładzie funcji fibonacciego
        // jeżeli nie wiesz co to silnia to wejdź tutaj: http://pl.wikipedia.org/wiki/Silnia

        static int silnia (int n) { // funkcja "silnia" licząca silnię ze zmniennej "n"
        int wynik = 1;				// gdybyśmy podali wynik zmiennej "wynik" równy 0 to za każdym razem otrzymywalibyśmy wartość 0 
        for (int i =1;i<=n;i++) {   // pętla for: będzie ona się kończyć gdy zmienna "i" będzie równa lub mniejsza ( znaczek <= ) od zmiennej "n" 
            wynik *=i;              // wartość wyniku za każdym razem będzie mnożona przez zmienną "i" której wartość rośnie 
                                    // inaczej można to zapisać jako: wynik = wynik * i;
        }                       // koniec pętli
        // podaję przykład: wartość 3! = 6 = 1*2*3 więc pętla wykona się trzy razy : (1*1)*2*3 a dla 8! = (1*1)*2*3*4*5*6*7*8
        return wynik; // zwraca wartość funkcji
        }
        
        static int silniar (int n) { // funcja robi to samo co porzednia ale robi to w sposób rekurencyjny
        if (n == 0)    // dla 0 
            return 1;  // funkcja zwraca nam wartość 1
            else       // w przeciwnym wypadku
            return n * silniar (n-1);  // będzie wykonywany ten wzór. Tym razem  mnożenie będzie wykonywane od liczby największej do najmniejszej
                                       // 4! = 4*3*2*1 ale w przypadku mnożenia nie ma to znaczenia (przemienność)
        }
        
        static void Main(string[] args) {  // funkcja Main
        
            Console.WriteLine ("Podaj liczbę: "); // wypisujemy tekst
            string liczba = Console.ReadLine();   // podajemy zmienną "liczba"
            int n = int.Parse(liczba);            // przerabiamy ją na zmienną "n"
            
            Console.WriteLine("Wynik przy zastosowaniu zwykłej funkcji:" + silnia(n)); // wypisujemy wartość funkcji silnia
            Console.WriteLine("Wynik przy użyciu funkcji silniar: " + silniar(n));     // wypisujemy wartość funkcji silniar
            // program będzie poprawnie pokazywał wartości do 12! 
        }
    }
}

