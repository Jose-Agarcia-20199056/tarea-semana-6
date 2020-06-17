using System;
					
public class Program
{
	public static void Main()
	{

    String r = "";
	    var random = new Random();

        while(r != "s"){
		int n = random.Next(50, 100);
		
		Console.WriteLine("numero random detectado: "+ n.ToString());
		Console.WriteLine("pulse cualquier letra para generar otro numero random o 'S' = Salir");
		r= Console.ReadLine();	
		}

	}
}