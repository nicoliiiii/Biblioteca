using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    class UsuarioEntidade
    {
        public int ID { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }

        public object[] Linha()
        {
            return new object[] { ID,LOGIN,SENHA};
        }
    }
}
