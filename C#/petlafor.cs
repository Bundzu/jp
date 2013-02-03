using System;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args) {

            //Typowe zastosowanie pętli for: wypisyjemy co dziesiątą liczbę od 0 to 1000 
            for (int i=0;i <= 1000 ; i=i+10)
            // Pierwsze wyrażenie to wartość zmiennej "i" która wynosi 0 ;
       		// drugie wyrażenie to warunek wyjścia po którym dziłanie pętli się kończy (liczba mniejsza lub równa 1000) ;
       		// trzecie wyrażenie to to co robi się przy każdym przejściu pętli (w tym wypadku wartośc zmiennej "i" rośnie co 10) ; 
            {
                Console.WriteLine(i); // tutaj wypisane są wszystkie liczby z pętli
            }
            Console.ReadLine(); 	  // naciskamy enter aby zamknąć program
        }
    }
}
