using System;
using System.Net.Http;
using System.Xml.Linq;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		HttpClient client = new HttpClient();







		string url = "https://www.w3schools.com/xml/simple.xml";

		string response = await client.GetStringAsync(url);

		XDocument doc = XDocument.Parse(response);

		var foods = doc.Descendants("food");




		foreach (var food in foods)
		{
			string nome = food.Element("name").Value;
			string preco = food.Element("price").Value;

			Console.WriteLine(nome);
			Console.WriteLine(preco);
		}
	}
}