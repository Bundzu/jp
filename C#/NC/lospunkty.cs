using System;
namespace ConsoleApplication {
    class Program{
        static void Main(string[] args){
        Random random = new Random();
        int los = random.Next(100);
        
        int liczba;
        int punkty = 5;
        
        do{
        Console.Write("Zgadnij liczbę od 0 do 100, masz "+ punkty +" prób:  ");
        string x = Console.ReadLine(); 
        liczba =int.Parse(x);		   
        
            if (liczba>los){
            Console.WriteLine("Za duża liczba spróbuj ponownie \n");
            punkty--;
            }
                else
                if (liczba<los){
                Console.WriteLine("Za mała liczba spróbuj ponownie \n");
                punkty--;
                }
                    else
                    Console.WriteLine("Wygrałeś");
                    
                    if (punkty == 0) {
                    Console.WriteLine("Przegrałeś");
                    }
        }while(liczba != los && punkty != 0);
        }
    }
}
