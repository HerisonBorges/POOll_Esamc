
using System;
using System.IO;
using System.Xml.Serialization;


public class Produto
{
	public string Nome { get; set; }
	public double Preco { get; set; }
}

class Program
{
	static void Main()
	{
		Produto p1 = new Produto();
		p1.Nome = "Mouse";
		p1.Preco = 50;

		Produto p2 = new Produto();
		p2.Nome = "Teclado";
		p2.Preco = 100;

		Produto p3 = new Produto();
		p3.Nome = "Monitor";
		p3.Preco = 800;

		Produto[] produtos = new Produto[3];
		produtos[0] = p1;
		produtos[1] = p2;
		produtos[2] = p3;

		XmlSerializer serializer = new XmlSerializer(typeof(Produto[]));

		using (StreamWriter writer = new StreamWriter("produtos.xml"))
		{
			serializer.Serialize(writer, produtos);
		}

		string conteudo = File.ReadAllText("produtos.xml");
		Console.WriteLine(conteudo);
	}
}
