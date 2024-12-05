using Biblioteca.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Biblioteca.DAO
{
    class DAOLivros
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;

        public DAOLivros()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }
        public void Inserir(LivrosEntidade livro)
        {
            Conexao.Open();
            string query = "insert into Livros (TituloLivro, AutorId, Genero,Classificacao,NumPag,AnoPubli,Disponivel) Values(@titulolivro, @autorid, @genero, @classificacao, @numpag,@anopubli, @disponivel)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlParameter parametro1 = new MySqlParameter("@TituloLivro", livro.TituloLivro);
            MySqlParameter parametro2 = new MySqlParameter("@AutorId", livro.AutorId);
            MySqlParameter parametro3 = new MySqlParameter("@Genero", livro.Genero);
            MySqlParameter parametro4 = new MySqlParameter("@Classificacao", livro.Classificacao);
            MySqlParameter parametro5 = new MySqlParameter("@NumPag", livro.NumPag);
            MySqlParameter parametro6 = new MySqlParameter("@AnoPubli", livro.AnoPubli);
            MySqlParameter parametro7 = new MySqlParameter("@Disponivel", livro.Disponivel);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.Parameters.Add(parametro6);
            comando.Parameters.Add(parametro7);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
       
        public DataTable ObterLivro()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT LivroId,TituloLivro, AutorId, Genero,Classificacao,NumPag,AnoPubli,Disponivel FROM Livros ORDER BY LivroId desc";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

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
                query = "SELECT * AutorId FROM Livros ORDER BY LivroId desc";
            }
            else
            {
                query = "SELECT * FROM Livros WHERE TituloLivro LIKE '%" + pesquisa + "%' ORDER BY LivroId desc";
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            Conexao.Close();
            return dt;
        }
    }
}
