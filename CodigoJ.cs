using System;
using System.Collections.Generic;

class Program
{
	static int NumeroMenor(List<int> lista)
	{
		int menor = lista[0];
		
		foreach (int numero in lista)
		{
			if (numero < menor)
				{
				menor = numero;
				}			
		}
		return menor;
	}
	static void Main()
	{
		Console.WriteLine("Insira o tamanho da lista: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		List<int> numeros = new List<int> ();
		
		if (tamanho > 6)
		{
			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			int numero = int.Parse(Console.ReadLine());
			
			numeros.Add(numero);
        
			}
		}
		else
		{
			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			int numero = int.Parse(Console.ReadLine());
			
			numeros.Add(numero);
        
			}
		}
    
		int menor = NumeroMenor(numeros);
		
		Console.WriteLine("O menor número da lista é {0}.", menor);
		Console.ReadKey(true);
	}
	
}
