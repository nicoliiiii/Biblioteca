using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Classes;
using Biblioteca.Forms;
using Biblioteca.Forms.Cadastro;

namespace Biblioteca
{
    public partial class Login : Form
    {
        private Biblioteca.Classes.Login login;
   

       


        public Login()
        {
            InitializeComponent();
            login = new Biblioteca.Classes.Login();
        }

       
        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            login.LOGIN = txtLogin.Text;
            login.SENHA = txtSenha.Text;
            if (login.Logar())
            {
                Principal p = new Principal();
                p.FormClosed += FecharForm;
                this.Hide();
                p.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Usuarios n = new Usuarios();
            n.ShowDialog();
        }
    }
}
