﻿using System;

namespace ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            

            int min = 99999999;  
            int max = -99999999; 
            for(int i=1 ; i <=5 ; i++)
            {
                Console.WriteLine("podaj liczbę: ");        
				string tekst = Console.ReadLine();  
				int x = int.Parse(tekst);           
                if (x < min) 
                    min = x; 
                if (x > max) 
				max = x;
            }                
            Console.WriteLine("Największa liczba: " + max);  
			Console.WriteLine("Najmniejsza liczba: " + min); 
			Console.ReadLine();  
		}
    }
}
