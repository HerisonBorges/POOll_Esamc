using System;

class Program
{
	static void Main()
	{
		try
		{
			Conta conta1 = new Conta(100, "Maria", 1000m);
			Conta conta2 = new Conta(200, "João", 500m);

			Console.WriteLine("ANTES:");
			Console.WriteLine(conta1);
			Console.WriteLine(conta2);

			conta1.Depositar(100);
			Console.WriteLine("\nDEPOIS DO DEPÓSITO:");
			Console.WriteLine(conta1);

			conta1.Sacar(200);
			Console.WriteLine("\nDEPOIS DO SAQUE:");
			Console.WriteLine(conta1);

			conta1.Transferir(conta2, 300);
			Console.WriteLine("\nDEPOIS DA TRANSFERÊNCIA:");
			Console.WriteLine(conta1);
			Console.WriteLine(conta2);

			Console.WriteLine("\nTESTANDO LIMITE DIÁRIO:");

			conta1.Sacar(400);
			Console.WriteLine("Saque 1 OK");

			conta1.Sacar(200);
			Console.WriteLine("Saque 2 OK");

			Console.WriteLine("\nDigite um valor para sacar:");
			string texto = Console.ReadLine();

			decimal valorDigitado = decimal.Parse(texto);

			conta1.Sacar(valorDigitado);

			Console.WriteLine("\nSAQUE DIGITADO REALIZADO:");
			Console.WriteLine(conta1);
		}
		catch (FormatException)
		{
			Console.WriteLine("\nERRO:");
			Console.WriteLine("Você digitou um valor inválido. Digite apenas números.");
		}
		catch (LimiteDiarioException ex)
		{
			Console.WriteLine("\nERRO DE LIMITE:");
			MostrarDetalhes(ex);
		}
		catch (SaldoInsuficienteException ex)
		{
			Console.WriteLine("\nERRO DE SALDO:");
			MostrarDetalhes(ex);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine("\nERRO DE VALIDAÇÃO:");
			MostrarDetalhes(ex);
		}
		catch (Exception ex)
		{
			Console.WriteLine("\nERRO INESPERADO:");
			MostrarDetalhes(ex);
		}
	}

	static void MostrarDetalhes(Exception ex)
	{
		Console.WriteLine("Message: " + ex.Message);
		Console.WriteLine("StackTrace: " + ex.StackTrace);

		if (ex.InnerException != null)
		{
			Console.WriteLine("InnerException: " + ex.InnerException.Message);
		}
	}
}











// Exercício 5
// Correção:
// catch (Exception)
// {
//     throw;
// }
//
// Explicação:
// "throw ex" perde o StackTrace original.
// "throw" mantém o StackTrace, sendo a forma correta.



// Exercício 7


// 1. Por que usar exceção personalizada?
// Exceções personalizadas permitem representar erros específicos da regra de negócio,
// como saldo insuficiente ou limite de saque.
// Isso deixa o código mais organizado, legível e facilita tratar cada tipo de erro separadamente.

// 2. Qual a função do InnerException?
// InnerException armazena a exceção original que causou o erro atual.
// Isso permite rastrear a causa raiz do problema e ajuda no debug,
// mantendo o histórico completo do erro.

// 3. Onde o erro deve ser tratado: Conta ou Main?
// A classe Conta deve lançar as exceções (throw) quando ocorre um erro.
// O tratamento deve ser feito no Main, que é responsável por mostrar mensagens
// ao usuário ou decidir o que fazer com o erro.