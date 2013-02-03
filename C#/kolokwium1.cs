using System;
namespace ConsoleApplication {
    class Program {
        static void Main(string[] args){
	/*kolokwium z dnia 21.11.2012 roku dla grupy C6
	 * 
	 * zadanie 1
	 * Użyszkodnik podaje swoje średnie zarobki miesieczne a program ma obliczyć z tego podatek
	 * jeżeli są niższe niż 20 000 rocznie to podatek wynosi 10 % między 20 000 a 50 000 - 19 % powyżej 50 000 - 24 %
	 * nie może zostać wpisana wartość ujemna.
	 * Nie pamiętam jakie tam są dokładne liczby ale to nie jest ważne
	 */
        Console.WriteLine("Wpisz średnie zarobki miesieczne: ");
        
        string doch = Console.ReadLine ();
        float d = float.Parse(doch);
        
        if (d < 0) {
        Console.WriteLine("Zła wartość. Koniec programu");
        }
        else
        if ((d >0) && (d < 20000/12)) {
        Console.WriteLine ("Podatek wynosi: " + (d*12*0.1));
        }
        else
        if ((d > 20000/12) && (d < 50000/12)) {
        Console.WriteLine ("Podatek wynosi: " + (d*12*0.19));
        }
        else
        Console.WriteLine ("Podatek wynosi: " + (d*12*0.24));
        Console.ReadLine();

         /* zadanie 3
         * Należy zmniejszyć zmnienną x o 3, za jedno z rozwiązań jest 0.5 punktu
         * x-=3;
         * x= x - 3;
         */
         }
    }
}
