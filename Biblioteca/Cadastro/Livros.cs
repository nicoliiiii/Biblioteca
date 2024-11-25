using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Cadastro
{
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtTituloLivro.Text = "";
            txtNomeAutor.Text = "";
            txtGenero.Text = "";
            txtClassificaçao.Text = "";
            txtNumPag.Text = "";
            txtAnoPubli.Text = "";
            chkDisponivel.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "insert into Livros (TituloLivro, NomeAutor, Genero,Classificaçao,NumPag,) Values (@nome, @sigla, @ativo)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtNomeDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkCadastro.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
