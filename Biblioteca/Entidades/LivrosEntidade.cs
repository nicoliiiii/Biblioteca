using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    class LivrosEntidade
    {
        public int LivroId { get; set; }
        public string TituloLivro { get; set; }
        public int AutorId { get; set; }
        public string Genero { get; set; }
        public string Classificacao { get; set; }
        public string NumPag { get; set; }
        public string AnoPubli { get; set; }
        public bool Disponivel { get; set; }

        public object[] Linha()
        {
            return new object[] { LivroId,TituloLivro, AutorId, Genero, Classificacao, NumPag, AnoPubli, Disponivel };
        }
    }
}

