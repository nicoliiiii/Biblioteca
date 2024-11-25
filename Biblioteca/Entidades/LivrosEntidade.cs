using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    class LivrosEntidade
    {
        public string TituloLivro { get; set; }
        public string NomeAutor { get; set; }
        public string Genero { get; set; }
        public string Classificacao { get; set; }
        public string NumPag { get; set; }
        public string AnoPubli { get; set; }
        public bool Disponivel { get; set; }

        public object[] Linha()
        {
            return new object[] { TituloLivro, NomeAutor, Genero, Classificacao, NumPag, AnoPubli, Disponivel };
        }
    }
}

