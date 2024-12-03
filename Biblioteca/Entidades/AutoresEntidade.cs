using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    class AutoresEntidade
    {
        public int AutorId { get; set; }
        public string NomeAutor { get; set; }
        

        public object[] Linha()
        {
            return new object[] { AutorId, NomeAutor};
        }
    }
}
