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
        var produto = new Produto
        {
           Id = 1,
           Nome = "Macarrão",
           Preco = 30.00,
           Estoque = 15,
           CodigoInterno = 10

        };
       
        string json = JsonConvert.SerializeObject(produto, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(json);
    }
}
