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
            string query = "insert into autores (NomeAutor) Values(@nomeautor)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlParameter parametro1 = new MySqlParameter("@nomeautor", autor.NomeAutor);
            
           
            comando.Parameters.Add(parametro1);
           
            comando.ExecuteNonQuery(); 
            Conexao.Close();
        }
        public DataTable ObterAutor()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT AutorId, NomeAutor  FROM autores ORDER BY AutorId desc";
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
                query = "SELECT *  FROM autores ORDER BY AutorId desc";
            }
            else
            {
                query = "SELECT * FROM autores WHERE NomeAutor LIKE '%" + pesquisa + "%' ORDER BY AutorId desc";
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
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT AutorId, NomeAutor FROM autores";

            using (MySqlConnection connection = new MySqlConnection(LinhaConexao))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                try
                {

                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }
    }

}
