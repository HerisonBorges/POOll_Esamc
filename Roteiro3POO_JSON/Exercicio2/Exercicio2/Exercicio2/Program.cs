using System;
using System.IO;
using Newtonsoft.Json;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}

class Program
{
    static void Main()
    {
        var aluno = new Aluno
        {
            Nome = "Herison",
            Idade = 34,
            Curso = "Sistemas de informação"
        };

        string json = JsonConvert.SerializeObject(aluno, Formatting.Indented);

        File.WriteAllText("Aluno.json", json);

        Console.WriteLine("Arquivo criado");


        Aluno alunoJson = JsonConvert.DeserializeObject<Aluno>(json);
        Console.WriteLine($"Nome: {alunoJson.Nome} - Idade: {alunoJson.Idade} - Curso: {alunoJson}");
       




    }
}
