using System;
using System.Collections.Generic;

class Program
{
	static int MaiorNumero(List<int> numeros)
	{
		int maior = numeros[0];
		
		foreach (int numero in numeros)
		{
			if (maior < numero)
			{
				maior = numero;
			}
		}
		return maior;
	}
	
	static void Main()
	{
		List<int> listadeNumeros = new List<int>();
		
		Console.WriteLine("Insira a quantidade de itens da lista: ");
		int quantidade = int.Parse(Console.ReadLine());
		
		Console.WriteLine();
		
		if (quantidade > 6)
		{
			for (int i = 0; i < quantidade; i++)
			{
			Console.WriteLine("Insira {0}º da lista:", i + 1);
			int numero = int.Parse(Console.ReadLine());
			
			listadeNumeros.Add(numero);
			}
			Console.Clear();
		}
		
		else 
		{
			for (int i = 0; i < quantidade; i++)
			{
			Console.WriteLine("Digite o {0}º da lista:", i + 1);
			int numero = int.Parse(Console.ReadLine());
			
			listadeNumeros.Add(numero);
			}
		}
		
		int maior = MaiorNumero(listadeNumeros);
		
		Console.WriteLine("\n\rO maior número da lista é: {0}", maior);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
  
}
