using Newtonsoft.Json;
using System;
using System.Xml;

class Produto
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public double Preco { get; set; }

    public int Estoque { get; set; }

    public string Fornecedor { get; set; }

    public int CodigoInterno { get; set; }

}
class Program
{
    static void Main()
    {

        var produtoLista = new List<Produto>
        {
            new Produto{Id = 2, Nome = "Notebook", Preco = 2700, Estoque = 100, Fornecedor = "Lenovo"},
            new Produto{Id = 3, Nome = "Mouse", Preco = 270, Estoque = 10, Fornecedor = "Raiser"},
            new Produto{Id = 2, Nome = "Teclado", Preco = 270, Estoque = 100, Fornecedor = "Lenovo"}
        };
        var produto = new Produto
        {
            Id = 1,
            Nome = "Processador",
            Preco = 3000.00,
            Estoque = 15,
            Fornecedor = "Intel"

        };

        string json = JsonConvert.SerializeObject(produto, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(json);

        Console.ReadLine();
        string jsonLista = JsonConvert.SerializeObject(produtoLista, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("pessoas.json", jsonLista);
       
        string conteudo = File.ReadAllText("pessoas.json");
        var lista = JsonConvert.DeserializeObject<List<Produto>>(conteudo);

        foreach(var p in lista) { 
 
            Console.WriteLine($"{p.Id} - {p.Nome}  - {p.Preco} - {p.Estoque} - {p.Fornecedor}");
        }

    }
}
