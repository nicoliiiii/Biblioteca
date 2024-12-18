﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarLivro));
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.txtAutorId = new System.Windows.Forms.TextBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtTituloLivro.Location = new System.Drawing.Point(56, 197);
            this.txtTituloLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(148, 26);
            this.txtTituloLivro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(51, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo do Livro";
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalvarLivro.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnSalvarLivro.Location = new System.Drawing.Point(72, 578);
            this.btnSalvarLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(111, 46);
            this.btnSalvarLivro.TabIndex = 2;
            this.btnSalvarLivro.Text = "Salvar";
            this.btnSalvarLivro.UseVisualStyleBackColor = false;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // txtAutorId
            // 
            this.txtAutorId.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtAutorId.Location = new System.Drawing.Point(56, 257);
            this.txtAutorId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutorId.Name = "txtAutorId";
            this.txtAutorId.Size = new System.Drawing.Size(148, 26);
            this.txtAutorId.TabIndex = 3;
            // 
            // txtAnoPubli
            // 
            this.txtAnoPubli.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtAnoPubli.Location = new System.Drawing.Point(56, 503);
            this.txtAnoPubli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnoPubli.Name = "txtAnoPubli";
            this.txtAnoPubli.Size = new System.Drawing.Size(148, 26);
            this.txtAnoPubli.TabIndex = 5;
            // 
            // txtNumPag
            // 
            this.txtNumPag.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNumPag.Location = new System.Drawing.Point(56, 443);
            this.txtNumPag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumPag.Name = "txtNumPag";
            this.txtNumPag.Size = new System.Drawing.Size(148, 26);
            this.txtNumPag.TabIndex = 6;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtClassificacao.Location = new System.Drawing.Point(56, 383);
            this.txtClassificacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(148, 26);
            this.txtClassificacao.TabIndex = 7;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtGenero.Location = new System.Drawing.Point(56, 317);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(148, 26);
            this.txtGenero.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(51, 471);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Publicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(45, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero de paginas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label5.Location = new System.Drawing.Point(43, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Classificação Indicativa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label6.Location = new System.Drawing.Point(51, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gênero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.Location = new System.Drawing.Point(51, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome do Autor";
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.chkDisponivel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.chkDisponivel.Location = new System.Drawing.Point(70, 544);
            this.chkDisponivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(128, 33);
            this.chkDisponivel.TabIndex = 15;
            this.chkDisponivel.Text = "Disponivel";
            this.chkDisponivel.UseVisualStyleBackColor = false;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnExcluirLivro.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnExcluirLivro.Location = new System.Drawing.Point(74, 628);
            this.btnExcluirLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(111, 46);
            this.btnExcluirLivro.TabIndex = 16;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = false;
            this.btnExcluirLivro.Click += new System.EventHandler(this.btnExcluirLivro_Click);
            // 
            // txtLivroId
            // 
            this.txtLivroId.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtLivroId.Enabled = false;
            this.txtLivroId.Location = new System.Drawing.Point(56, 137);
            this.txtLivroId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLivroId.Name = "txtLivroId";
            this.txtLivroId.Size = new System.Drawing.Size(148, 26);
            this.txtLivroId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id Livro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(203)))), ((int)(((byte)(211)))));
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Editar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // EditarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(308, 692);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.txtAutorId);
            this.Controls.Add(this.btnSalvarLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloLivro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarLivro";
            this.Text = "EditarLivro";
            this.Load += new System.EventHandler(this.EditarLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.TextBox txtAutorId;
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
        private System.Windows.Forms.Label label8;
    }
}