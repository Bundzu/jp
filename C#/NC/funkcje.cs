using System;
namespace ConsoleApplication1{
    class Program{
        
        static int modul(int liczba){
            if (liczba <0){
            liczba = liczba * -1;
            }
        return liczba;
        }
        
        static void Main(string[] args){
        int x = modul(-5);
        Console.WriteLine(x);
        }
    }
}
