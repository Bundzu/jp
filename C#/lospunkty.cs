using System;
namespace ConsoleApplication {
    class Program {
        static void Main(string[] args){
		
/* w tym programie komputer losuje liczbę a użyszkodnik ma ją zgadnąć
 * w przypadku błędnej odpowiedzi program udzieli podpowiedzi w stylu:
 * "za duża liczba/za mała liczba" */

        /*system punktów do tej gry jest na pracę domową a 5.12.2012 r. będzie wejściówka dla grupy C6*/

        Random random = new Random(); // tutaj tworzymy liczbę losową
        int los = random.Next(100); // a tutaj zmienna los przyjmie wartośći od 0 do 100
        // Console.WriteLine(los); // odkomentuj tą linię aby sprawdzić czy komputer Cię nie oszukuje
        int liczba; // Zmienna liczba istnieje ale nie ma jeszcze żadnej wartości, wartość wpiszemy podczas działania pętli
        int punkty = 5; //Zmienna "punkty" wynosi w tym przypadku 5
        
        do{ // pętla się zaczyna
        
        Console.Write("Zgadnij liczbę od 0 do 100, masz "+ punkty +" prób:  "); // wypisanie tekstu, za każdym razem liczba prób się zmniejsza
        string x = Console.ReadLine(); // wpisujemy zmienną "x" 
        liczba =int.Parse(x);		   // która staje się zmienną "liczba"	
        
            if (liczba>los){ // jeżeli zmienna "liczba" jest większa od zmiennej "los"
            Console.WriteLine("Za duża liczba spróbuj ponownie \n"); // to wypisany zostanie ten tekst
            punkty--; //ponieważ jest to będna odpowiedź to tracisz jedną szansę na odpowiedź
            }
            
                 else // w przeiwnym razie
                 if (liczba<los){ // jeżeli zmienna "liczba" jest mniejsza od zmiennej "los"
                 Console.WriteLine("Za mała liczba spróbuj ponownie \n"); // zostanie wypisany ten tekst
                 punkty--; //ponieważ jest to będna odpowiedź to tracisz jedną szansę na odpowiedź
                 }
                 
                     else // w przeciwnym razie gdy nie zostaną spełnione warunki powyżej
                     Console.WriteLine("Wygrałeś"); 
                 
                 if (punkty == 0) { // jeżeli zmienna "punkty" wyniesie 0 to
                 Console.WriteLine("Przegrałeś"); // zostanie wypisany tekst
                 }

        }while(liczba != los && punkty != 0);  /* pętla kończy się gdy gracz zgadnie liczbę lub skończą mu się szanse
												* oczytuj to jako " pętla while będzie kontynuowana gdy zmienna "liczba"
												* nie będzie rowna zmiennej "los" i zmienna "punkty" nie będzie równa 0 */
        }
    }
}
