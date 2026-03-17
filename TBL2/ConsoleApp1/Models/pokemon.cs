using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public int BaseExperience { get; set; }

        public string Tipo { get; set; }
        public string Habilidade { get; set; }
    }
}