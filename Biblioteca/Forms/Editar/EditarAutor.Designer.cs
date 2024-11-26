
namespace Biblioteca.Forms.Editar
{
    partial class EditarAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.btnSalvarAutor = new System.Windows.Forms.Button();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(41, 61);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAutor.TabIndex = 0;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(38, 45);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(77, 13);
            this.lblNomeAutor.TabIndex = 1;
            this.lblNomeAutor.Text = "Nome do autor";
            // 
            // btnSalvarAutor
            // 
            this.btnSalvarAutor.Location = new System.Drawing.Point(55, 155);
            this.btnSalvarAutor.Name = "btnSalvarAutor";
            this.btnSalvarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAutor.TabIndex = 2;
            this.btnSalvarAutor.Text = "Salvar";
            this.btnSalvarAutor.UseVisualStyleBackColor = true;
            this.btnSalvarAutor.Click += new System.EventHandler(this.btnSalvarAutor_Click);
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(41, 116);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(100, 20);
            this.txtTituloLivro.TabIndex = 3;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Location = new System.Drawing.Point(42, 100);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(70, 13);
            this.lblTituloLivro.TabIndex = 4;
            this.lblTituloLivro.Text = "Titulo do livro";
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.Location = new System.Drawing.Point(55, 195);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAutor.TabIndex = 5;
            this.btnExcluirAutor.Text = "Excluir";
            this.btnExcluirAutor.UseVisualStyleBackColor = true;
            this.btnExcluirAutor.Click += new System.EventHandler(this.btnExcluirAutor_Click);
            // 
            // EditarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.btnExcluirAutor);
            this.Controls.Add(this.lblTituloLivro);
            this.Controls.Add(this.txtTituloLivro);
            this.Controls.Add(this.btnSalvarAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Name = "EditarAutor";
            this.Text = "EditarAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Button btnSalvarAutor;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Button btnExcluirAutor;
    }
}