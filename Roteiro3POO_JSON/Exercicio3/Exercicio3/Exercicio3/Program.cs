using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class Carro
{
    public string Marca { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
}

class Program
{
    static void Main()
    {
        var carros = new List<Carro>
        {
            new Carro { Marca = "BYD", Ano = 2023, Modelo = "modelo1" },
            new Carro { Marca = "Haval", Ano = 2023, Modelo = "modelo2" }
        };

        string json = JsonConvert.SerializeObject(carros, Formatting.Indented);

        File.WriteAllText("Carro.json", json);

        Console.WriteLine("Arquivo criado");

        List<Carro> carrosJson = JsonConvert.DeserializeObject<List<Carro>>(json);

        foreach (var p in carrosJson)
        {
            Console.WriteLine($"{p.Marca} - {p.Ano} - {p.Modelo}");
        }
    }
}