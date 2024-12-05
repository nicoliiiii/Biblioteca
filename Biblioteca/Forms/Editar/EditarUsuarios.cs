using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms.Editar
{
    public partial class EditarUsuarios : Form
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;
        public EditarUsuarios(int ID)
        {
            InitializeComponent();
            string query = "SELECT ID,LOGIN,SENHA FROM USUARIOS WHERE ID = @id";
            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@id", ID));
            MySqlDataReader Leitura = comando.ExecuteReader();
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    txtUsuarioId.Text = Leitura[0].ToString();
                    txtLoginUsuario.Text = Leitura[1].ToString();
                    txtSenhaUsuario.Text = Leitura[2].ToString();
                   

                }
            }
            Conexao.Close();

        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {

            string query = "update USUARIOS set ID= @id, LOGIN = @login, SENHA = @senha WHERE  ID = @id";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@id", txtUsuarioId.Text));
            comando.Parameters.Add(new MySqlParameter("@login", txtLoginUsuario.Text));
            comando.Parameters.Add(new MySqlParameter("@senha", txtSenhaUsuario.Text));
            



            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("usuario Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            string query = "Delete from USUARIOS WHERE  ID = @id";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", txtUsuarioId.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Usuario Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

