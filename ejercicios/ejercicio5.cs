using System;
					
public class Program
{
	public static void Main()
	{

  
// conteo de ceros		
	    int count = 1;
		int  num = 0;
		int  res =  0;
		int mult = 10;
		int cand = 1;
	    int otr = 100;
	    int  num2 = 1;
		Console.WriteLine("Aqui se mostrar cuantos ceros  hay del 1 al 100");
		
		while (count <= 9){
		
		  res = count*mult;
			
		Console.WriteLine(" se Detecto en el: "+res+" esta cantidad de ceros: "+cand);	
		 count = count+1;
		  num= num+1;
	

		 if (res==90){
			 num = num-7;
			
			 
			     Console.WriteLine(" se Detecto en el: "+otr+" esta cantidad de ceros:" +num);
		         Console.WriteLine("los ceros encontrados del 1 al 100 son:"+ cand+num2);
			 
			 
			 
		 }
		 
		 }	


	}
}