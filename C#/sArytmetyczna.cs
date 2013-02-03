using System;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            // W tym programie podamy 5 liczb z których wybrana będzie największa i najmniejsza a następnie wyliczamy średnią arytmetyczną tych liczb

            int min = 99999999; // zmienna "min" ma byc jak największa aby każda liczba "x" stała się najmniejszą liczbą,
                                // w ten sposób wyznaczymy najmniejszą liczbę którą program poda na końcu

            int max = -99999999; // podobnie jak powyżej tylko wyznaczamy największą liczbę więc zmnienna "max" ma być jak najmniejsza

            int s= 0; // dodaliśmy zmienną "s" która będzie sumą liczb "x" nie możemy podać innej wartości niż 0 bo nam wyjdzie zła suma

            for(int i=1 ; i <=5 ; i++)
            /* pętla for: zaczynamy od zmiennej "i" równej 1 a następnie zwiększamy jej wartość o 1 (i++) pętla kończy się gdy
            *  zmienna i jest mniejsza lub równa 5. W tym przypadku będziemy podawali 5 liczb
            */

            {
                Console.WriteLine("podaj liczbę: "); // pojawia się tekst zanim wpiszemy liczbę, możemy pominąć tą linię
                string tekst = Console.ReadLine();   // podajemy zmienną tekst
                int x = int.Parse(tekst);            // zmienna tekst jest przerabiana na zmienną x która jest liczbą całkowitą

                if (x < min)  // tutaj liczba x którą podawaliśmy w liniach 28-29 jest porównywana z liczbą "min"
                    min = x;  // jeżeli liczba "x" jest mniejsza od "min" to x staje się najmniejszą liczbą

                if (x > max)  // podobnie jak powyżej tylko że liczba "x" porównywana jest z liczbą "max"
                    max = x;

                s = s + x;    // bardzo ważna linia: suma "s" to liczba "x" + suma która na samym początku miała wartość 0
            }                 // tutaj się kończy pętla

            Console.WriteLine("Największa liczba: " + max);    // wypisywana jest liczba największa
            Console.WriteLine("Najmniejsza liczba: " + min);   // wypisywana jest liczba najmniejsza
            Console.WriteLine("Średnia arytmetyczna: " + s/5); // sumę "s" dzielimy przez 5 i otrzymujemy średnią arytmetyczną
            Console.ReadLine();                                // kończymy program 
        }
    }
}
