using System;
using Models;
using Services;

namespace PokedexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonService service = new PokemonService();
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("=== POKEDEX ===");
                Console.WriteLine("1 - Buscar Pokémon pelo nome");
                Console.WriteLine("2 - Buscar Pokémon aleatório");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome do Pokémon: ");
                        string nome = Console.ReadLine();

                        try
                        {
                            Pokemon p = service.BuscarPokemon(nome);
                            MostrarPokemon(p);
                        }
                        catch
                        {
                            Console.WriteLine("Pokémon não encontrado.");
                        }
                        break;

                    case "2":
                        Pokemon aleatorio = service.BuscarPokemonAleatorio();
                        MostrarPokemon(aleatorio);
                        break;

                    case "0":
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MostrarPokemon(Pokemon p)
        {
            Console.WriteLine("=== Pokémon Encontrado ===");
            Console.WriteLine($"ID: {p.Id}");
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Altura: {p.Altura}");
            Console.WriteLine($"Peso: {p.Peso}");
            Console.WriteLine($"Base Experience: {p.BaseExperience}");
            Console.WriteLine($"Tipo: {p.Tipo}");
        }
    }
}
