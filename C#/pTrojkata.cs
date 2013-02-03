using System;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            //to jest przykładowy komentarz
            /*A to jest przykładowy komentarz blokowy
             ten program obliczy nam pole trójkąta po podaniu dwóch zmiennych*/

            Console.WriteLine("Podaj długość"); // ta linia wypisuje nam co mamy podać (długość boku trójkąta)
            string dlugosc = Console.ReadLine(); /* za pomocą polecenia Console.ReadLine() podajemy zmienną string (ciąg znaków) 
                                                  * nie możemy od razu dać zmiennej typu int lub float 
                                                  * (int to liczby całkowite a float to liczby z miejscami po przecinku)
                                                  * bo wyskoczy nam błąd.   */
            int a = int.Parse(dlugosc); //tutaj przerabiamy zmienną "dlugosc" która jest ciągiem znaków na zmienną "a" która jest liczbą

            Console.WriteLine("Podaj wysokość"); //tutaj jest tak jak wyżej tylko że podajemy wysokość
            string wysokosc = Console.ReadLine();
            int h = int.Parse(wysokosc);

            Console.WriteLine("pole trójkąta wynosi: " + (a * h) / 2); /* Napierw ta linia wypisuje nam co robi ("pole trójkąta wynosi: ")
                                                                       * a następnie oblicza nam pole trójkąta ze zmiennych a i h które 
                                                                       * podawawaliśmy na początku programu, warto pamiętac o plusie
                                                                       * między tekstem a wzorem */
            Console.ReadLine(); // naciskamy enter aby zamknąć program
        }
    }
}
