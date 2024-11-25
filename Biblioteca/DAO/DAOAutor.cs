using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class DAOAutor
    {
        private string LinhaConexao = "Server=localhost;Database=Biblioteca;Uid=root;Pwd=;";
        private MySqlConnection Conexao;

        public DAOAutor()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }
    }

}
