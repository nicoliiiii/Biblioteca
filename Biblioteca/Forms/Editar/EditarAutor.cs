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
    public partial class EditarAutor : Form
    {
        private string LinhaConexao = "Server=localhost;Database=Biblioteca;Uid=root;Pwd=;";
        private MySqlConnection Conexao;
        public EditarAutor(string NomeAutor)
        {
            InitializeComponent();

            string query = "SELECT NomeAutor, TituloLivro FROM Autores WHERE NomeAutor = @nomeautor";
            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@nomeautor", NomeAutor));
            MySqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
               
                    txtNomeAutor.Text = Leitura[0].ToString();
                    txtTituloLivro.Text = Leitura[1].ToString();

                }
            }
            Conexao.Close();

        }

        private void btnSalvarAutor_Click(object sender, EventArgs e)
        {
            string query = "update Autores set NomeAutor = @nomeautor, TituloLivro = @titulolivro WHERE  NomeAutor = @nomeautor";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@nomeautor", txtNomeAutor.Text));
            comando.Parameters.Add(new MySqlParameter("@titulolivro", txtTituloLivro.Text));
          

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Autor(a) Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluirAutor_Click(object sender, EventArgs e)
        {
            string query = "Delete from Autores WHERE  NomeAutor = @nomeautor";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@nomeautor", txtNomeAutor.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Autor(a) Excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

    

