using Xunit;
using AulaTestesExercicio1;

namespace AulaTestesExercicio1.Tests
{
	public class ValidadorSenhaTests
	{
		[Fact]
		public void Senha_DeveSerValida()
		{
			var validador = new ValidadorSenha();

			var resultado = validador.EhValida("Senha123");

			Assert.True(resultado);
		}

		[Fact]
		public void Senha_SemNumero_DeveSerInvalida()
		{
			var validador = new ValidadorSenha();

			var resultado = validador.EhValida("abcdefgh");

			Assert.False(resultado);
		}

		[Fact]
		public void Senha_Vazia_DeveSerInvalida()
		{
			var validador = new ValidadorSenha();

			var resultado = validador.EhValida("");

			Assert.False(resultado);
		}

		[Fact]
		public void Senha_SemLetra_DeveSerInvalida()
		{
			var validador = new ValidadorSenha();

			var resultado = validador.EhValida("12345678");

			Assert.False(resultado);
		}
	}
}