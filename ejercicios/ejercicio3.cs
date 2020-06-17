using System;
					
public class Program
{
	public static void Main()
	{
        // cantidad de digitos
int num,dg = 0;
		Console.WriteLine("Escriba un numero positivo please");
		num = int.Parse(Console.ReadLine());
	 
	    if(num < 0){
			
			Console.WriteLine("Ingrese un numero positivo please");
		  }
		
		
		  
			
		else{
			
			do
			{
			 num= num/10;
			  dg = dg + 1; 	 
			} while ( num > 0);
			 
			Console.WriteLine(" El numero de digitos es {0}",dg );
			
			}



	}
}