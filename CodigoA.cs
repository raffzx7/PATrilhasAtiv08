using System;

namespace PATrilhasAtiv07
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro: ");
			int numero = int.Parse(Console.ReadLine());
			
			int resultado = CalcularQuadrado(numero);
			
			Console.Clear();
		
			Console.WriteLine("O quadrado do número {0} é {1}", numero, resultado);
			Console.WriteLine("Pressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
		
		static int CalcularQuadrado (int num)
		{
			return num * num;
		}
		
		}
	}
