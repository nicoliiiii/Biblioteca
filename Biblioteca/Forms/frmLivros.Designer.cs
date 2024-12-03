
namespace Biblioteca.Forms
{
    partial class frmLivros
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
            this.dtGridLivros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridLivros
            // 
            this.dtGridLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLivros.Location = new System.Drawing.Point(23, 139);
            this.dtGridLivros.Name = "dtGridLivros";
            this.dtGridLivros.Size = new System.Drawing.Size(738, 299);
            this.dtGridLivros.TabIndex = 0;
            
            this.dtGridLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridLivros_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(23, 113);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(338, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(382, 110);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(151, 23);
            this.btnNovoLivro.TabIndex = 3;
            this.btnNovoLivro.Text = "Adicionar novo Livro";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoLivro);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridLivros);
            this.Name = "frmLivros";
            this.Text = "frmLivros";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnNovoLivro;
    }
}