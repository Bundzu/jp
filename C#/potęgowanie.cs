using System;
namespace ConsoleApplication1{
    class Program{
    // ten fajny program potęguje nam różne liczby 
        static int potega (int podstawa, int wykladnik) {
        // funkcja będzie nam mnożyć podstawę (int podstawa) przez określoną liczbę podstaw (int wykladnik)
            int wynik = podstawa; // tworzymy zmienną wynik która wynosi w tej chwili tyle co podstawa, wszystkie wartości podamy na końcu
            for (int i =1 ; i< wykladnik; i++){ // pętla for: wszystko będzie się mnożyć dopóki zmienna "i" nie stanie się wmniejsza od wartości wykładnika
            wynik = wynik * podstawa; // z każdym cyklem pętli wynik będzie mnożony o następną wartość podstawy:
                                      // np. chcemy spotęgować 2 do potęgi 3 - końcowy wynik wyjdzie nam : wynik = 2*2*2
                                      // pętla wykona się 2 razy ponieważ podaliśmy aby kończyła się gdy "i" nie będzie równe wartości wykładnika (i< wykladnik;)
                                      // za pierwszym razem wynik będzie wynosił 4 a następnie wynik zostanie znowu pomnożony o 2 dając 8. 
            }                         // koniec pętli
            return wynik; 		// zwraca nam wartość wyniku
            } 					// koniec funkcji

        static void Main(string[] args) { // nowa funkcja

        Console.Write("Podaj podstawę: "); 		// wypisywanie tekstu
        string tekst = Console.ReadLine(); 	// podajemy zmienną tekst która jest słowem
        int podstawa = int.Parse(tekst);   		// a następnie zmieniamy ją na zmienną "podstawa" która jest zmienną liczbową
        
        Console.Write("Podaj wykładnik: "); 	//podobnie jak powyżej tylko że podajemy wykładnik
        string tekst1 = Console.ReadLine();
        int wykladnik = int.Parse(tekst1);
        
        Console.WriteLine("Wynik: " + potega(podstawa,wykladnik)); // bardzo ważna linia: przy pomocy funkcji "potega" podana podstawa jest mnożona tyle razy 
																	   // ile podaliśmy w zmiennej "wykladnik"
        }
    }
}
