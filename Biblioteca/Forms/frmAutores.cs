using Biblioteca.Cadastro;
using Biblioteca.DAO;
using Biblioteca.Entidades;
using Biblioteca.Forms.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class frmAutores : Form
    {
        DataTable dados;
        DAOAutor dao = new DAOAutor();
        int LinhaSelecionada;
        public frmAutores()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(AutoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridAutor.DataSource = dao.ObterAutor();
        }

        private void dtGridAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string NomeAutor = Convert.ToString(dtGridAutor.Rows[e.RowIndex].Cells[0].Value);
                EditarAutor editar = new EditarAutor(NomeAutor);
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridAutor.DataSource = dao.ObterAutor();
        }

        private void btnNovoAutor_Click(object sender, EventArgs e)
        {
            Autor a = new Autor();
            a.FormClosed += Fechou_Editar_FormClosed;
            a.ShowDialog();
        }
    }
}
