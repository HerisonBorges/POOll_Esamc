using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace AulaTestesExercicio0
{
	public class Item
	{
		public string Nome { get; set; } = string.Empty;
		public double Preco { get; set; }
	}

	public class Carrinho
	{
		private List<Item> itens = new List<Item>();

		public void Adicionar(Item item)
		{
			itens.Add(item);
		}

		public List<Item> ObterItens()
		{
			return itens;
		}
	}
}