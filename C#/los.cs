using System;
namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
        /* w tym programie komputer losuje liczbę a użyszkodnik ma ją zgadnąć
         * w przypadku błędnej odpowiedzi program udzieli podpowiedzi w stylu:
         * "za duża liczba/za mała liczba" */
        Random random = new Random(); // tutaj tworzymy liczbę losową
        int los = random.Next(100); // a tutaj zmienna los przyjmie wartośći od 0 do 100
        // Console.WriteLine(los); // odkomentuj tą linię aby sprawdzić czy komputer Cię nie oszukuje
        // int liczba; // Zmienna liczba istnieje ale nie ma jeszcze żadnej wartości, wartość wpiszemy podczas działania pętli
   
        do{ // pętla się zaczyna
        Console.Write("Zgadnij liczbę od 0 do 100:  "); // wypisanie tekstu
        string x = Console.ReadLine(); // wpisujemy zmienną "x" 
        liczba =int.Parse(x);		   // która staje się zmienną "liczba"	
        if (liczba>los){ // jeżeli zmienna "liczba" jest większa od zmiennej "los"
        Console.WriteLine("Za duża liczba spróbuj ponownie"); // to wypisany zostanie ten tekst
        }
            else // w przeiwnym razie
            if (liczba<los){ // jeżeli zmienna "liczba" jest mniejsza od zmiennej "los"
            Console.WriteLine("Za mała liczba spróbuj ponownie"); // zostanie wypisany ten tekst
            }
                else // w przeciwnym razie gdy nie zostaną spełnione warunki powyżej
                Console.WriteLine("Wygrałeś"); 
        } while(liczba!=los); // pętla kończy się gdy gracz zgadnie liczbę
        
        }
    }
}
