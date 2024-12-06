using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
   public class Login
    {
        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;");
        public string LOGIN { get; set; }
        public string SENHA { get; set; }

        public bool Logar()
        {
            string query = "Select LOGIN, ID from USUARIOS where SENHA = @senha AND LOGIN = @login";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@senha", SENHA));
            comando.Parameters.Add(new MySqlParameter("@login", LOGIN));
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
