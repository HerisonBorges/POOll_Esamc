using Xunit;
using AulaTestesExercicio4;

namespace AulaTestesExercicio4.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Idade_Valida_DeveRetornarTrue()
		{
			var validador = new ValidadorIdade();

			var resultado = validador.EhValida(25);

			Assert.True(resultado);
		}

		[Fact]
		public void Idade_Negativa_DeveRetornarFalse()
		{
			var validador = new ValidadorIdade();

			var resultado = validador.EhValida(-1);

			Assert.False(resultado);
		}

		[Fact]
		public void Idade_MuitoAlta_DeveRetornarFalse()
		{
			var validador = new ValidadorIdade();

			var resultado = validador.EhValida(150);

			Assert.False(resultado);
		}
	}
}