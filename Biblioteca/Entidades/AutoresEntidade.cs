using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    class AutoresEntidade
    {
        public string NomeAutor { get; set; }
        public string TituloLivro { get; set; }

        public object[] Linha()
        {
            return new object[] { TituloLivro, NomeAutor};
        }
    }
}
