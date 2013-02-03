using System;
namespace ConsoleApplication1{
  class Program{
  // ten fajny program potęguje nam różne liczby, wzięto też pod uwagę potęgi z minusem i 0 
    static double potega (double podstawa, double wykladnik) {
    // funkcja będzie nam mnożyć podstawę (int podstawa) przez określoną liczbę podstaw (int wykladnik)
    double wynik = podstawa;// tworzymy zmienną wynik która wynosi w tej chwili tyle co podstawa, wszystkie wartości podamy na końcu
		
    if (wykladnik > 0){  // tutaj robimy obliczenia dla wykładnika dodatniego
      for (int i =1 ; i< wykladnik; i++){  // pętla for: wszystko będzie się mnożyć dopóki zmienna "i" nie stanie się wmniejsza od wartości wykładnika
      wynik = wynik * podstawa;	 // z każdym cyklem pętli wynik będzie mnożony o następną wartość podstawy
        }  // koniec pętli
      }
      else  // w przeciwnym razie

    if (wykladnik < 0){	 // tutaj robimy obliczenia dla wykładnika ujemnego
      for (int i = -1; i > wykladnik; i--){  // wszystko tutaj jest jak powyżej tylko że przewnym znakiem
      wynik= wynik * podstawa;				
      } 							
      wynik = (1/wynik);  // na koniec jeden jest dzielony przez wartość wyniku, otrzymujemy potęgę
      }
      else        // w przeciwnym razie
      wynik = 1;  // dla potęgi 0 wynik zawsze wyjdzie 1
      return wynik;  // zwraca nam wynik
    }  // koniec funkcji

  static void Main(string[] args) {  // nowa funkcja

    Console.Write("Podaj podstawę: ");  // wypisywanie tekstu
    string tekst = Console.ReadLine();  // podajemy zmienną tekst która jest słowem
    double podstawa = double.Parse(tekst);  // a następnie zmieniamy ją na zmienną "podstawa" która jest zmienną liczbową

    Console.Write("Podaj wykładnik: ");  // to samo co powyżej dla wykładnika
    string tekst1 = Console.ReadLine();
    double wykladnik = double.Parse(tekst1);

    Console.WriteLine("Wynik: " + potega(podstawa,wykladnik));  // wynik
    }
  }
}
