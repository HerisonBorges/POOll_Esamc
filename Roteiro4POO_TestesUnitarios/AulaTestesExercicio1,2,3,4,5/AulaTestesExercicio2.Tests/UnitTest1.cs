using Xunit;
using AulaTestesExercicio2;

namespace AulaTestesExercicio2.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void DeveSomarTotalCorretamente()
		{
			var carrinho = new Carrinho();

			carrinho.Adicionar(new Item { Nome = "A", Preco = 10 });
			carrinho.Adicionar(new Item { Nome = "B", Preco = 20 });

			var total = carrinho.Total();

			Assert.Equal(30, total);
		}

		[Fact]
		public void DeveLimparCarrinho()
		{
			var carrinho = new Carrinho();

			carrinho.Adicionar(new Item { Nome = "A", Preco = 10 });

			carrinho.Limpar();

			Assert.Empty(carrinho.ObterItens());
		}

		[Fact]
		public void DeveRetornarQuantidadeCorreta()
		{
			var carrinho = new Carrinho();

			carrinho.Adicionar(new Item());
			carrinho.Adicionar(new Item());

			var quantidade = carrinho.Quantidade();

			Assert.Equal(2, quantidade);
		}
	}
}