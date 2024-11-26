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
    public partial class EditarLivro : Form
    {
        private string LinhaConexao = "Server=localhost;Database=Biblioteca;Uid=root;Pwd=;";
        private MySqlConnection Conexao;
        public EditarLivro(string TituloLivro)
        {
            InitializeComponent();
            string query = "SELECT TituloLivro, NomeAutor, Genero,Classificacao,NumPag,AnoPubli,Disponivel FROM Livros WHERE TituloLivro = @titulolivro";
            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@titulolivro", TituloLivro));
            MySqlDataReader Leitura = comando.ExecuteReader();
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    txtTituloLivro.Text = Leitura[0].ToString();
                    txtNomeAutor.Text = Leitura[1].ToString();
                    txtGenero.Text= Leitura[2].ToString();
                   txtClassificacao.Text = Leitura[3].ToString();
                   txtNumPag.Text = Leitura[4].ToString();
                   txtAnoPubli.Text = Leitura[5].ToString();
                   chkDisponivel.Checked = Convert.ToBoolean(Leitura[6]);

                }
            }
            Conexao.Close();

        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            string query = "update Livros set TituloLivro = @titulolivro, NomeAutor = @nomeautor,Genero = @genero,Classificacao = @classificacao,NumPag = @numpag, AnoPubli = @anopubli,Disponivel = @disponivel WHERE  TituloLivro = @titulolivro";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@titulolivro", txtTituloLivro.Text));
            comando.Parameters.Add(new MySqlParameter("@nomeautor", txtNomeAutor.Text));
            comando.Parameters.Add(new MySqlParameter("@genero", txtGenero.Text));
            comando.Parameters.Add(new MySqlParameter("@classificacao", txtClassificacao.Text));
            comando.Parameters.Add(new MySqlParameter("@numpag", txtNumPag.Text));
            comando.Parameters.Add(new MySqlParameter("@anopubli", txtAnoPubli.Text));
            comando.Parameters.Add(new MySqlParameter("@disponivel", chkDisponivel.Checked));



            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Livro Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            string query = "Delete from Livros WHERE  TituloLivro = @titulolivro";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@titulolivro", txtTituloLivro.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Livro Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
