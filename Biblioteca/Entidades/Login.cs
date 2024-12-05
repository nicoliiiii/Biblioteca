using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
   public class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public object[] Linha()
        {
            return new object[] { Usuario, Senha };
        }
    }
}
