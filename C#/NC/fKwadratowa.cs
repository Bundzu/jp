using System;

namespace Funkcja {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Podaj wartość a"); 
            string a1=Console.ReadLine(); 
			float a=float.Parse(a1);       
	    			          
            Console.WriteLine("Podaj wartość b");
			string b1 = Console.ReadLine();
            float b = float.Parse(b1);
            
            Console.WriteLine("Podaj wartość c"); 
			string c1 = Console.ReadLine();
            float c = float.Parse(c1);


            float delta = (b*b-4*a*c); 

            if (delta > 0) 	
			Console.WriteLine("funkcja ma 2 miejsca zerowe: " + (-b - Math.Sqrt(delta) / 2 * a ) + " i " + (-b + Math.Sqrt(delta) / 2* a));
		        else 
				if (delta == 0) 
                   Console.WriteLine("funkcja ma 1 miejsce zerowe: " + (-b / 2*a)); 
                else  
                    Console.WriteLine("funkcja nie ma miejsc zerowych."); 
            Console.ReadLine(); 
			}
    }
}
