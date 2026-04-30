using System;
using BibliotecaFinanceira; 
using BibliotecaValidacoes; 

namespace AppTesteFinanceiro
{
	class Program
	{
		static void Main(string[] args)
		{
			
			CalculadoraJuros fin = new CalculadoraJuros();
			double resultadoJuros = fin.JurosSimples(1000, 0.05, 12);

			
			Console.WriteLine("{resultadoJuros}");

		

			Console.WriteLine("\n-------------------------------\n");

		
			var validador = new Validador(); // [cite: 147]

			
			Console.WriteLine("CPF é válido? " + validador.ValidarCPF("123.456.789-00")); 
			Console.WriteLine("Email é válido? " + validador.ValidarEmail("teste@esamc.br"));
			Console.WriteLine("Senha é válida? " + validador.ValidarSenha("123456")); 

		}
	}
}