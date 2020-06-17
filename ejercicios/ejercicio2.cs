using System;
					
public class Program
{
	public static void Main()
	{// numeros primos
        int n, r;
		
		 Console.WriteLine("Ingrese un numero positivo please");
		  n = Convert.ToInt32(Console.ReadLine());
		
		  r= n % 2;
		
		 if (r !=0){
			Console.WriteLine("el  numero es primo ");
			 
		 }	 
		
		 else if (n<0){
			 
			 Console.WriteLine("ingrese un numero positivo please ");
			 
			 
		 }	 
			 
        else{
		
			Console.WriteLine(" el numero no primo ");
			
		}	







	}
}