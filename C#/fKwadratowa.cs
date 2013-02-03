using System;

namespace Funkcja {
    class Program {
        static void Main(string[] args) {
            /*w tym programie podamy wartości a, b i c funkcji kwadratowej oraz obliczymy ilość miejsc zerowych i miejsca zerowe*/
            Console.WriteLine("Podaj wartość a"); // Console.WriteLine  wypisuje nam tekst
            string a1=Console.ReadLine(); // podajemy zmnienną a1 (tekst) poprzez polecenie Console.ReadLine
            float a=float.Parse(a1);      // za pomocą polecenia float.Parse(a1) przerabiamy zmienną a1 (tekst) na zmienną a (liczby z przecinkiem) 
	    			          // nie mogilśmy od razu do wpisania w linii powyżej dać zmiennej float zamiast string
            Console.WriteLine("Podaj wartość b"); // podobnie tylko że otrzymujemy zmienną b1 którą przerabiamy na b
            string b1 = Console.ReadLine();
            float b = float.Parse(b1);
            
            Console.WriteLine("Podaj wartość c"); // tak samo jak powyżej
            string c1 = Console.ReadLine();
            float c = float.Parse(c1);


            float delta = (b*b-4*a*c);  //tutaj ze wzoru jest ustalona zmienna delta którą użyjemy w obliczeniach


            if (delta > 0) 		// jeśli zmienna delta jest większa o zera (po podaniu liczb a b i c) to:
                Console.WriteLine("funkcja ma 2 miejsca zerowe: " + (-b - Math.Sqrt(delta) / 2 * a ) + " i " + (-b + Math.Sqrt(delta) / 2* a));
		/* Wypisywana jest wiadomość o znalezieniu miejsc zerowych a następinie liczy na to ze wzoru Math.Sqrt() to pierwiastek, 
		 * pamiętaj o plusach w pomiędzy tekstem a wzorem  np: Console.WriteLine("tekst" + wzór + "tekst" + wzór + "itd.");
		*/
	        else // else znaczy "albo, w przeciwnym razie" więc jeżeli delta nie spełni warunku w 29 linii to będą wykonywane następne wyliczenia
                if (delta == 0) // jeśli zmienna "delta" jest równa 0 to:
                   Console.WriteLine("funkcja ma 1 miejsce zerowe: " + (-b / 2*a)); // "tekst" + wzór
                else // jeżeli żaden z dwóch warunków nie został spełniony powyżej to znaczy że funkcja nie ma miejsc zerowych 
                    Console.WriteLine("funkcja nie ma miejsc zerowych."); // i tutaj jest podawana wiadomość

            Console.ReadLine(); // możemy zakończyć program naciskając enter
        }
    }
}
