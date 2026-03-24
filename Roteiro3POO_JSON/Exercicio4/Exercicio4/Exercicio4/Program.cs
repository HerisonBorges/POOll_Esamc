using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
      
        JObject conexao = new JObject
        {
            ["Servidor"] = 2000,
            ["Porta"] = 30,
            ["Usuario"] = "Herison"
        };

     
        string json = conexao.ToString();

    
        File.WriteAllText("Conexao.json", json);
  

   
        string jsonLido = File.ReadAllText("Conexao.json");

        JObject conexaoLida = JObject.Parse(jsonLido);

        Console.WriteLine("Servidor: " + conexaoLida["Servidor"]);
        Console.WriteLine("Porta: " + conexaoLida["Porta"]);
        Console.WriteLine("Usuario: " + conexaoLida["Usuario"]);
    }
}