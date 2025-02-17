using System;

class Program
{
	static int Soma(int num1, int num2)
	{
		return num1 + num2;
	}
	static void Main()
	{
		Console.WriteLine("insira o primeiro número: ");
		int	numero1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Insira o segundo número: ");
		int	numero2 = int.Parse(Console.ReadLine());
		
		Console.Clear();
		
		int soma = Soma(numero1, numero2);
		
		Console.WriteLine("A soma dos numeros {0} + {1} é: {2}", numero1, numero2, soma);
		Console.ReadKey(true);			
  }
  
}
