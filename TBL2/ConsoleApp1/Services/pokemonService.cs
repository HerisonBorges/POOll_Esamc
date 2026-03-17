using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Models;

namespace Services
{
    public class PokemonService
    {
        private Random random = new Random();

        public Pokemon BuscarPokemon(string nome)
        {
            HttpClient client = new HttpClient();
            string url = $"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}";
            string response = client.GetStringAsync(url).Result;

            JObject json = JObject.Parse(response);

            Pokemon p = new Pokemon
            {
                Id = (int)json["id"],
                Nome = (string)json["name"],
                Altura = (int)json["height"],
                Peso = (int)json["weight"],
                BaseExperience = (int)json["base_experience"],
                Tipo = (string)json["types"][0]["type"]["name"]
            };

            return p;
        }

        public Pokemon BuscarPokemonAleatorio()
        {
            int idAleatorio = random.Next(1, 1026);

            HttpClient client = new HttpClient();
            string url = $"https://pokeapi.co/api/v2/pokemon/{idAleatorio}";
            string response = client.GetStringAsync(url).Result;

            JObject json = JObject.Parse(response);

            Pokemon p = new Pokemon
            {
                Id = (int)json["id"],
                Nome = (string)json["name"],
                Altura = (int)json["height"],
                Peso = (int)json["weight"],
                BaseExperience = (int)json["base_experience"],
                Tipo = (string)json["types"][0]["type"]["name"]
            };

            return p;
        }
    }
}
