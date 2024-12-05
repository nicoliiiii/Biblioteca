using MySql.Data.MySqlClient;
using Biblioteca.Entidades;
using System.Data;
using System;

namespace Biblioteca.DAO
{
     class DAOUsuarios
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;

        public DAOUsuarios()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }

        public void Inserir(UsuarioEntidade usuario)
        {
            Conexao.Open();
            string query = "Insert into USUARIOS (LOGIN , SENHA) " +
                "               Values (@login, @senha) ";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            MySqlParameter parametro1 = new MySqlParameter("@login", usuario.LOGIN );
            MySqlParameter parametro2 = new MySqlParameter("@senha", usuario.SENHA);
            

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable ObterUsuarios()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, LOGIN,SENHA FROM USUARIOS ORDER BY ID desc";
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
                query = "SELECT * ID FROM USUARIOS ORDER BY ID desc";
            }
            else
            {
                query = "SELECT * FROM USUARIOS WHERE LOGIN LIKE '%" + pesquisa + "%' ORDER BY ID desc";
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

        

