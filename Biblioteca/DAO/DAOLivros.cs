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
            string query = "insert into Livros (TituloLivro, NomeAutor, Genero,Classificacao,NumPag,AnoPubli,Disponivel) Values(@titulolivro, @nomeautor, @genero, @classificacao, @numpag,@anopubli, @disponivel)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlParameter parametro1 = new MySqlParameter("@TituloLivro", livro.TituloLivro);
            MySqlParameter parametro2 = new MySqlParameter("@NomeAutor", livro.NomeAutor);
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
            string query = "SELECT TituloLivro, NomeAutor, Genero,Classificacao,NumPag,AnoPubli,Disponivel FROM Livros ORDER BY TituloLivro desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);


            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(LivrosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    LivrosEntidade l = new LivrosEntidade();
                    l.TituloLivro = Leitura[0].ToString();
                    l.NomeAutor = Leitura[1].ToString();
                    l.Genero = Leitura[2].ToString();
                    l.Classificacao = Leitura[3].ToString();
                    l.NumPag = Leitura[4].ToString();
                    l.AnoPubli = Leitura[5].ToString();
                    l.Disponivel = Convert.ToBoolean(Leitura[6]);
                    dt.Rows.Add(l.Linha());
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
                query = "SELECT * FROM Livros ORDER BY TituloLivro desc";
            }
            else
            {
                query = "SELECT * FROM Livros WHERE TituloLivro LIKE '%" + pesquisa + "%' ORDER BY TituloLivro desc";
            }

            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            MySqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(LivrosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    LivrosEntidade l = new LivrosEntidade();
                    l.TituloLivro = Leitura[0].ToString();
                    l.NomeAutor = Leitura[1].ToString();
                    l.Genero = Leitura[2].ToString();
                    l.Classificacao = Leitura[3].ToString();
                    l.NumPag = Leitura[4].ToString();
                    l.AnoPubli = Leitura[5].ToString();
                    l.Disponivel = Convert.ToBoolean(Leitura[6]);
                    dt.Rows.Add(l.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
