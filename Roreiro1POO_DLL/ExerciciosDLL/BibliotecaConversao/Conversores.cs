namespace BibliotecaConversao
{
	public class Conversores
	{
		public double CelsiusParaFahrenheit(double celsius)
		{
			return (celsius * 9.0 / 5.0) + 32;
		}

		public double MetrosParaQuilometros(double metros)
		{
			return metros / 1000.0;
		}


		public double ConverterMoeda(double valor, double taxaCambio)
		{
			return valor * taxaCambio;
		}
	}
}