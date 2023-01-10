using System;
					
public class Program
{
	private static int p1;
	private static int p2;
	
	public static void Main()
	{
		p1 = 0;
		p2 = 0;
		Random rand = new Random();
		while (true)
		{
			if(!NextPoint(rand.Next(0, 2)))
			{
				break;
			}
		}
		//Console.ReadLine();
	}
	
	private static bool NextPoint(int i)
	{
		if(i == 0)
		{
			p1++;
		}
		else
		{
			p2++;
		}
		string[] datos = new string[] {"Love", "15", "30", "40"};
		string resultado = "";
		bool comparar = p1 > 3 || p2 > 3;
		bool fin = false;
		if(p1 <= 3)
		{
			resultado = datos[p1];
		}
		if(p2 <= 3)
		{
			resultado += " " + datos[p2];
		}
		if(comparar)
		{
			if(p1 == p2)
			{
				resultado = "Deuce";
			}
			else
			{
				fin = p1 - 1 > p2 || p2 - 1 > p1;
				resultado = (fin ? "Ha ganado " : "Ventaja") + (p1 > p2 ? "P1" : "P2");
			}
		}
		Console.WriteLine("P" + (i + 1).ToString() + "   " + resultado);
		return !fin;
	}
}
