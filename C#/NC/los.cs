using System;
namespace ConsoleApplication {
    class Program{
        static void Main(string[] args){

        Random random = new Random();
        int los = random.Next(100);
        int liczba; 
        do{ 
        Console.Write("Zgadnij liczbę od 0 do 100:  ");
        string x = Console.ReadLine();
        liczba =int.Parse(x);
        if (liczba>los){
        Console.WriteLine("Za duża liczba spróbuj ponownie");
		}
            else
            if (liczba<los){
            Console.WriteLine("Za mała liczba spróbuj ponownie");
            }
                else 
                Console.WriteLine("Wygrałeś"); 
        }while(liczba!=los);
        }
    }
}
