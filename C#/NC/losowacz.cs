using System;

namespace Tibia{
    class Program{ 
        static void losuj (int [] tab){
        
        int los;
        bool sprawdzajDalej; 
        Random losowacz = new Random ();
        
        for (int i = 0; i < 6; i++ ){
            sprawdzajDalej = false;
               do {
               los = losowacz.Next(49)+1 ;
                   for (int j = 0; j < i; j++){
                       if (los == tab [j]) {
                       sprawdzajDalej = true;
                       }
                           else sprawdzajDalej = false;   
                   }
               }while (sprawdzajDalej);
           tab[i] = los;
        }        
        }

        static void wyswietl (int [] tab) {
            foreach (int el in tab){
            Console.WriteLine(el);
            }
        }

        static void Main(string[] args){
        int [] tab = new int [6];

        losuj (tab);
        wyswietl (tab);
        }
    }
}
