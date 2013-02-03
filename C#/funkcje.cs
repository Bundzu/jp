using System;
namespace ConsoleApplication1{
    class Program{
       // ten program wyświetla nam moduł z liczby (która została podana w linii 13) 
        static int modul(int liczba){ // została stworzona funkcja o nazwie "modul" oraz zmienna "liczba"
            if (liczba <0){ // jeżeli zmienna liczba jest mniejsza od 0 to:
            liczba = liczba * -1; // mnożymy ją przez przez -1 więc stanie się dodatnia
            }
        return liczba; //zwracamy liczbę
        } // koniec funkcji

        static void Main(string[] args){ // funkcja "Main"
        int x = modul(-5); // tworzymy zmienną "x" która wynosi moduł z -5
        Console.WriteLine(x); // pokazana zostaje wartość zmniennej "x"
        }
    }
}
