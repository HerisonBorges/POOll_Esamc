namespace AulaTestesExercicio5
{
	public class CalculadoraDesconto
	{
		public double AplicarDesconto(double valor)
		{
			if (valor >= 100)
			{
				return valor * 0.9;
			}

			return valor;
		}
	}
}