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
        string conteudoLeituraJSON = File.ReadAllText("produtos.json");

        List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(conteudoLeituraJSON);

        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id} - Nome: {produto.Nome} - Preço: {produto.Preco} - Estoque: {produto.Estoque} - Fornecedor: {produto.Fornecedor}");
        }
    }
}
