using Xunit;
using AulaTestesExercicio5;

namespace AulaTestesExercicio5.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void DeveAplicarDesconto()
		{
			var calc = new CalculadoraDesconto();

			var resultado = calc.AplicarDesconto(200);

			Assert.Equal(180, resultado);
		}

		[Fact]
		public void NaoDeveAplicarDesconto()
		{
			var calc = new CalculadoraDesconto();

			var resultado = calc.AplicarDesconto(50);

			Assert.Equal(50, resultado);
		}
	}
}