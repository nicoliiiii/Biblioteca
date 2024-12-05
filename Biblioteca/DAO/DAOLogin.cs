using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    class DAOLogin
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;
        public DAOLogin()
        {
            Conexao = new MySqlConnection(LinhaConexao);
        }
        public bool Logar(string LOGIN, string SENHA)
        {
            string query = "Select LOGIN, ID from USUARIOS where LOGIN = @login AND  SENHA = @senha";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@login", LOGIN));
            comando.Parameters.Add(new MySqlParameter("@senha", SENHA));
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.HasRows)
            {
                Conexao.Close();
                return true;
            }
            else
            {
                Conexao.Close();
                return false;
            }


        }
    }
}

    
