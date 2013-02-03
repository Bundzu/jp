using System;
namespace Tibia{
    class Program{
        static void Main(string[] args){
        int [,] tablica = new int [4,5];
        tablica [1,1] = 7;
        for (int y = 0; y < 4 ; y++){
            for (int x = 0; x <5; x++){
                Console.Write (tablica [y,x]);
                }
            Console.WriteLine ();
            }
        
        Console.WriteLine ();

        int [][] tablicax = new int [6] [];
        for (int i = 0; i< tablicax.Length; i++){
            tablicax [i] = new int [8];
        }
        for (int z = 0; z < tablicax.Length; z++){
            for (int a = 0; a< tablicax[z].Length; a++){
               Console.Write (tablicax [z][a]);
               }
               Console.WriteLine ();
           }

        }
    }
}
