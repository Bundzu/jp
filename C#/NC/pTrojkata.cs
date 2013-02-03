using System;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Podaj długość"); 
			string dlugosc = Console.ReadLine(); 
             int a = int.Parse(dlugosc); 

            Console.WriteLine("Podaj wysokość"); 
			string wysokosc = Console.ReadLine();
            int h = int.Parse(wysokosc);

            Console.WriteLine("pole trójkąta wynosi: " + (a * h) / 2); 
			Console.ReadLine(); 
        }
    }
}
