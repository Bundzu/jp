using System;

namespace ConsoleApplication {
class Program{
    static double potega (double podstawa, double wykladnik) {
    double wynik = podstawa;
    if (wykladnik > 0){
        for (int i =1 ; i< wykladnik; i++){
        wynik = wynik * podstawa;
            }
    }
        else
        if (wykladnik < 0){
        
            for (int i = -1; i > wykladnik; i--){
            wynik= wynik * podstawa;
            }
            wynik = (1/wynik);	
            }
            
            else
            wynik = 1;
            return wynik;
            }
       
        static void Main(string[] args) {
            Console.Write("Podaj podstawę: ");
            string tekst = Console.ReadLine();
            double podstawa = double.Parse(tekst);
            
            Console.Write("Podaj wykładnik: ");
            string tekst1 = Console.ReadLine();
            double wykladnik = double.Parse(tekst1);
            
            Console.WriteLine("Wynik: " + potega(podstawa,wykladnik));
        }
    }
}
