using Xunit;
using AulaTestesExercicio3;

namespace AulaTestesExercicio3.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void DeveConverterCelsiusParaFahrenheit()
		{
			var conv = new ConversorTemperatura();

			var resultado = conv.CelsiusParaFahrenheit(0);

			Assert.Equal(32, resultado);
		}

		[Fact]
		public void DeveConverterFahrenheitParaCelsius()
		{
			var conv = new ConversorTemperatura();

			var resultado = conv.FahrenheitParaCelsius(32);

			Assert.Equal(0, resultado);
		}
	}
}