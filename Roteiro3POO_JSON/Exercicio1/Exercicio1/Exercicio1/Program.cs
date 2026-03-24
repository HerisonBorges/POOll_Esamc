using Newtonsoft.Json;
using System;

class Livro
{
    public string Titulo { get; set; }
    public int Ano { get; set; }
    public string Autor { get; set; }
}

class Program
{
    static void Main()
    {
        var livro = new Livro
        {
            Titulo = "Fanged Noumena",
            Ano = 2008,
            Autor = "Nick Land"
        };

        string json = JsonConvert.SerializeObject(livro, Formatting.Indented);
        Console.WriteLine(json);

            string jsonArq = JsonConvert.SerializeObject(livro, Formatting.Indented);

            File.WriteAllText("livro.json", jsonArq);

            
        
    }
}
