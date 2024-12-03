
namespace Biblioteca.Forms.Editar
{
    partial class EditarLivro
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
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtAnoPubli = new System.Windows.Forms.TextBox();
            this.txtNumPag = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.txtLivroId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(37, 128);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(100, 20);
            this.txtTituloLivro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo do Livro";
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Location = new System.Drawing.Point(48, 372);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(74, 30);
            this.btnSalvarLivro.TabIndex = 2;
            this.btnSalvarLivro.Text = "Salvar";
            this.btnSalvarLivro.UseVisualStyleBackColor = true;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(37, 167);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAutor.TabIndex = 3;
            // 
            // txtAnoPubli
            // 
            this.txtAnoPubli.Location = new System.Drawing.Point(37, 323);
            this.txtAnoPubli.Name = "txtAnoPubli";
            this.txtAnoPubli.Size = new System.Drawing.Size(100, 20);
            this.txtAnoPubli.TabIndex = 5;
            // 
            // txtNumPag
            // 
            this.txtNumPag.Location = new System.Drawing.Point(37, 284);
            this.txtNumPag.Name = "txtNumPag";
            this.txtNumPag.Size = new System.Drawing.Size(100, 20);
            this.txtNumPag.TabIndex = 6;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(37, 245);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(100, 20);
            this.txtClassificacao.TabIndex = 7;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(37, 206);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Publicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero de paginas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Classificação Indicativa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome do Autor";
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(47, 349);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(75, 17);
            this.chkDisponivel.TabIndex = 15;
            this.chkDisponivel.Text = "Disponivel";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(49, 408);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(74, 30);
            this.btnExcluirLivro.TabIndex = 16;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            this.btnExcluirLivro.Click += new System.EventHandler(this.btnExcluirLivro_Click);
            // 
            // txtLivroId
            // 
            this.txtLivroId.Enabled = false;
            this.txtLivroId.Location = new System.Drawing.Point(37, 89);
            this.txtLivroId.Name = "txtLivroId";
            this.txtLivroId.Size = new System.Drawing.Size(100, 20);
            this.txtLivroId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id Livro";
            // 
            // EditarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLivroId);
            this.Controls.Add(this.btnExcluirLivro);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtNumPag);
            this.Controls.Add(this.txtAnoPubli);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.btnSalvarLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloLivro);
            this.Name = "EditarLivro";
            this.Text = "EditarLivro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtAnoPubli;
        private System.Windows.Forms.TextBox txtNumPag;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.TextBox txtLivroId;
        private System.Windows.Forms.Label label2;
    }
}