using Biblioteca.Entidades;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class DAOAutor
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
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
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }
        public DataTable ObterAutor()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT NomeAutor,TituloLivro FROM Autores ORDER BY NomeAutor desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);


            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(AutoresEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    AutoresEntidade a = new AutoresEntidade();
                    a.NomeAutor = Leitura[0].ToString();
                    a.TituloLivro = Leitura[1].ToString();
                    dt.Rows.Add(a.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT * FROM Autores ORDER BY NomeAutor desc";
            }
            else
            {
                query = "SELECT * FROM Autores WHERE NomeAutor LIKE '%" + pesquisa + "%' ORDER BY NomeAutor desc";
            }

            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(AutoresEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) 
            {
                while (Leitura.Read())
                {
                    AutoresEntidade a = new AutoresEntidade();
                    a.NomeAutor = Leitura[0].ToString();
                    a.TituloLivro = Leitura[1].ToString();
                    dt.Rows.Add(a.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }

}
