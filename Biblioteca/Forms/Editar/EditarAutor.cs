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
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;
        public EditarAutor(int AutorId)
        {
            InitializeComponent();

            string query = "SELECT AutorId, NomeAutor FROM autores WHERE AutorId = @autorid";
            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@autorid", AutorId));

            MySqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
               
                    txtIdAutor.Text = Leitura[0].ToString();
                    txtNomeAutor.Text = Leitura[1].ToString();

                }
            }
            Conexao.Close();

        }

        private void btnSalvarAutor_Click(object sender, EventArgs e)
        {
            string query = "update autores set AutorId = @autorid, NomeAutor = @nomeautor WHERE AutorId = @autorid";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@autorid", txtIdAutor.Text));
            comando.Parameters.Add(new MySqlParameter("@nomeautor", txtNomeAutor.Text));


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

            string query = "Delete from Autores WHERE AutorId= @autorid";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@autorid", txtIdAutor.Text));
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

        private void EditarAutor_Load(object sender, EventArgs e)
        {

        }
    }
    }

    

