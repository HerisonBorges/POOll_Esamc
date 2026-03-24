using System;
using System.Xml.Linq;

class Program
{
	static void Main()
	{
		XDocument doc = XDocument.Load("estoque.xml");

		var itens = doc.Descendants("item");

		foreach (var item in itens)
		{
			string nome = item.Element("nome").Value;

			if (nome == "Mouse")
			{
				item.Element("quantidade").Value = "10";
			}
		}

		doc.Save("estoque.xml");

		Console.WriteLine("XML atualizado.");
	}
}