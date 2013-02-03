using System;
namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
        // w tym programie wykorzystamy pętlę while do wypisania liczb od 1 do 10 a następnie od 1 do 20

        int q=0, s=0; // zmienna  q wynosi 0 tak samo jak zmienna s

        while(q<10){ // pętla while będzie wykonywana dopóki zmienna q będzie mniejsza od liczba 10
        q++; // tutaj podnosimy wartość zmiennej q o jeden
        Console.Write(q + " "); // Wypisujemy zmienną q w jednej linii a następnie dopisujemy po niej spację aby liczby się nie zlewały
        } // pętla zakończy się gdy zmienna q będzie miała wartość 10

        Console.WriteLine("\n"); // dodajemy 2 nowe linie dla zwiększenia czytelnośći

        do{ // "do while" to inny sposób zapisania pętli while
        s++; // zwiększamy wartość zmiennej s o 1
        Console.WriteLine(s); // wypisujemy zmienną s, tym razem liczby wypisywane będą w nowej linii
        }while(s<20); // pętla zakończy się gdy zmienna s osiągnie wartość 20
        }
    }
}
