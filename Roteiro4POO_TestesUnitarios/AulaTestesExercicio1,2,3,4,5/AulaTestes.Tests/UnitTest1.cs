using Xunit;
using AulaTestesExercicio0;
using System;
using System.Collections.Generic;

namespace AulaTestes.Tests
{
	public class UnitTest1
	{
		
		[Fact]
		public void Somar_DeveRetornar5()
		{
			var calc = new Calculadora();
			var resultado = calc.Somar(2, 3);

			Assert.Equal(5, resultado);
		}

		
		[Fact]
		public void Dividir_DeveLancarExcecao()
		{
			var calc = new Calculadora();

			Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
		}

		
		[Fact]
		public void Carrinho_DeveEstarVazio()
		{
			var carrinho = new Carrinho();

			Assert.Empty(carrinho.ObterItens());
		}

		
		[Fact]
		public void Classificar_DeveRetornarObesidade()
		{
			var calc = new CalculadoraIMC();
			var resultado = calc.Classificar(31);

			Assert.Equal("Obesidade", resultado);
		}
	}
}