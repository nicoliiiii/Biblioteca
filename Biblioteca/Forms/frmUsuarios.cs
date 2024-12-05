using Biblioteca.Cadastro;
using Biblioteca.DAO;
using Biblioteca.Entidades;
using Biblioteca.Forms.Cadastro;
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
    public partial class frmUsuarios : Form
    {
        DataTable dados;
        DAOUsuarios dao = new DAOUsuarios();
        int LinhaSelecionada;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(UsuarioEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridUsuario.DataSource = dao.ObterUsuarios();
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridUsuario.DataSource = dao.ObterUsuarios();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.FormClosed += Fechou_Editar_FormClosed;
            u.ShowDialog();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtGridUsuario.DataSource = dao.Pesquisar(txtPesquisar.Text);
        }

        private void dtGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ID = Convert.ToInt32(dtGridUsuario.Rows[e.RowIndex].Cells[0].Value);
                EditarUsuarios editar = new EditarUsuarios(ID);
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
        }
    }
}
