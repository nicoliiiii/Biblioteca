using Biblioteca.Entidades;
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
        public void Inserir(AutoresEntidade autor)
        {
            Conexao.Open();
            string query = "insert into Autores (NomeAutor,TituloLivro) Values(@nomeautor, @titulolivro)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlParameter parametro1 = new MySqlParameter("@nomeautor", autor.NomeAutor);
            MySqlParameter parametro2 = new MySqlParameter("@titulolivro", autor.TituloLivro);
           
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
    }

}
