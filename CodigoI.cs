using System;
using System.Collections.Generic;

class Program
{
	static bool NumeroPrimo(int entrada)
	{
		if (entrada < 2)
		{
			return false;
		}
		
			for (int i = 2; i <= Math.Sqrt(entrada); i++)
			{
				if (entrada % i == 0)
				{
					return false;
				}
			}
		return true;
	}
	static void Main()
	{
		Console.WriteLine("Insira um número inteiro: ");
		int numero = int.Parse(Console.ReadLine());
		
		Console.WriteLine();
		
		bool resultado = NumeroPrimo(numero);
			
			if (resultado)
			{
				Console.WriteLine("Verdadeiro");
			}
			else 
			{
				Console.WriteLine("Falso");
			}
		Console.ReadKey(true);
	}
	
}
