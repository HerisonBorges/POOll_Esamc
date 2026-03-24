using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTestesExercicio0
{
	public class Calculadora
	{
		public int Somar(int a, int b)
		{
			return a + b;
		}

		public double Dividir(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException();

			return (double)a / b;
		}
	}
}
