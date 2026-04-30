using System;

namespace BibliotecaFinanceira
{
	public class CalculadoraJuros
	{
		
		public double JurosSimples(double capital, double taxa, int tempo)
		{
			return capital * taxa * tempo;
		}

		
		internal double CalculoInterno(double valor)
		{
			return valor * 0.1;
		}
	}
}